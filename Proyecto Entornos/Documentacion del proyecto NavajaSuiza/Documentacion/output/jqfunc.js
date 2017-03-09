
// set the fixed header height 
function checkFixedHeaderHeight() {
    var headerDiv = $("div.PageHeaderArea_fixedheader");
    var contentDiv = $("div.PageClientArea_fixedheader");
    if ((headerDiv != null) && (contentDiv != null)) {
       contentDiv.css("padding-top", headerDiv.height());
    }
}

// dictionary from comma separated list
function categoryDictionaryFromString(categoryIds) {
    var result = {};
    
    if (categoryIds != null) {
        var ids = categoryIds.split(",");

        var i;
        for (i = 0; i < ids.length; i++) {
            var id = trimString(ids[i]);
            if (id.length > 0) {
                result[id] = true;
            }
        }
    }
    
    return result;
}

// comma separated list from dictionary
function categoryListFromDictionary(dictionary) {
    var result = "";
    
    for (key in dictionary) {
        if (dictionary[key]) {
            if (result != "") {
                result += ",";
            }
            result += key;
        }
    }
    
    return result;
}

// returns true if any key in rowCategoriesDict is contained in filteredCategoriesDict 
function containsAnyCategory(filteredCategoriesDict, rowCategoriesDict) {
    var result = false;
    
    for (cat in rowCategoriesDict) {
        var val = filteredCategoriesDict[cat];
        if ((val != null) && (val === true)) {
            result = true;
        }
    }
    
    return result;
}

// sets checked state of a category checkbox
function setCategoryCheckboxState(categoryId, checked) {
    $("input[type='checkbox'][value='" + categoryId +"']").each( function() {
        $(this).prop("checked", checked);
    });
}

// updates the category table's visibility based in whether it has visible rows
function updateCategoryTableVisibility() {
    $("div.NavigationTable > div > table").each( function () {
        // we can't check :visible directly because this doesn't
        // work if the containing table is currently hidden.
        var allRowsHidden = true;
        
        var visibleRows = $(this).children("tbody").children("tr").each (function () {
            if ($(this).css("display") !== "none") {
                allRowsHidden = false;
                return false;
            }
        });
        
        var placeholder = $(this).closest("div.NavigationTable").siblings("div.TableCategories").children("div.TableCategoriesTableEmpty"); 
        
        if (allRowsHidden) {
            $(this).hide();        
            placeholder.show();
        } else {
            $(this).show();        
            placeholder.hide();
        }                                  
    });
}


// Set adds or removes a category from the filtered list
// If categoryId = null, restores the current setup
function setCategoryVisibility(categoryId, visible) {

    var categories = loadVariable(filteredCategoriesStoreName);
    var theFilteredCategories = categoryDictionaryFromString(categories);

    if (categoryId != null) {
        theFilteredCategories[categoryId] = !visible;
    }
    
    if ((categoryId != null) || (!(jQuery.isEmptyObject(theFilteredCategories)))) {
        $("tr[data-category-ids]").each( function() {
            var idlist = $(this).attr("data-category-ids");
            
            var rowCategories = categoryDictionaryFromString(idlist);
            
            if (containsAnyCategory(theFilteredCategories, rowCategories)) {
                $(this).hide();
            } else {
                $(this).show();
            } 
        });
    }
    
    if (categoryId != null) {
        setCategoryCheckboxState(categoryId, visible);
   
        categories = categoryListFromDictionary(theFilteredCategories);
        saveVariable(filteredCategoriesStoreName, categories);
    } else {
        if (!(jQuery.isEmptyObject(theFilteredCategories))) {
            for (cat in theFilteredCategories) {
                setCategoryCheckboxState(cat, false);
            }
        }
    }
    
    updateCategoryTableVisibility();
}

// service function
function getCSSPixelProperty(jqobj, name) {
    return parseInt(jqobj.css(name).replace(/[^-\d\.]/g, ""));
}

// fits the topic path entries into the available space 
// by hiding entries starting at the left-hand side 
function fitTopicPath() {
    var path = $("div.PageHeaderTopicPaths").first();
    
    if (!path.length) 
        return;
        
    var entries = path.find("span.TopicPathEntry");
    
    entries.show();
    path.find("span.TopicPathSeparator").show();
    
    var pathElement = path[0];
    var availableWidth = pathElement.offsetWidth;
    var current = pathElement.scrollWidth;

    if (current > availableWidth) {
        var numberOfEntries = entries.length;
        entries.each( function(idx) {
            // don't hide the last entry, even if it doesn't fit
            if (idx < (numberOfEntries-1)) { 
                $(this).hide();
                $(this).nextAll("span.TopicPathSeparator").first().hide();
        
                current = pathElement.scrollWidth;            
                return (availableWidth < current);
            }
        });
    }        
}

function fadeInWelcomeControls() {
    setTimeout(function() {
	    $(".PageHeaderGlobalLinks > span.PageLink").animate({opacity: '1'}, 1000);
    }, 1000);
    setTimeout(function() {
	    $("div.madewith_dom").animate({opacity: '1'}, 1000);
    }, 2000);
}

var lastEmbeddedFeatureContentFilename = "";

$(function() {
    // tears down any open popup and background 
    function closeEmbeddedFeature() {
        if ($("div.EmbeddedFeatureBackground").is(':visible')) {
            $("div.EmbeddedFeatureBackground").hide();
            $("div.EmbeddedFeature").hide();
            $("div.Popup_Block").hide();
            $("div.TopicPathPopup_Block").hide();
        } 
    }
    
    // we need to update the fixed header and topic path when the window is resized
    $(window).on("resize", function() {
        checkFixedHeaderHeight();
        closeEmbeddedFeature();
        fitTopicPath();
    });

    // toggles a section
    $("div.SectionHeading").click(function() {
        toggleVisibility($(this).attr("id"), true);
    });

    // toggles a TOC folder in response to the expand/collapse image being clicked
    $(document).on("click", "div.ContentLevel > div.ContentFolder > img", function () {
        toggleVisibility($(this).closest("div").attr("id"), false);
    });

    // toggles a TOC group in response to the expand/collapse image being clicked
    $(document).on("click", "div.ContentLevel > div.ContentGroup > img", function () {
        toggleVisibility($(this).closest("div").attr("id"), false);
    });
    
    // toggles all expandable sections
    $("div.CollapseExpandLink > span").click(function() {
        var showSections = ($(this).hasClass("expandAll"));
        
        $("div.CollapseExpandLink > span").show();
        $(this).hide();
        
        $("div.SectionHeading.expandable").each(function() {
            var sectionId = $(this).attr("id");
            setSectionVisibility(sectionId, showSections);
        });
         
    });
    
    
    // places a popup feature (embedded feature, section popup or topic path popup)
    function placePopupFeature(feature, relativeTo, center, paddingElement) {
        var screenpos = relativeTo.offset();
        var padding = getCSSPixelProperty(feature, "padding-top");
        var scrlTop = $(window).scrollTop(); 
        var scrlLeft = $(window).scrollLeft();
        var windowWidth = $(window).width();
        var featureWidth = feature.outerWidth(); 
        
        screenpos.top = Math.round(screenpos.top - padding - scrlTop);
        if (center) {
            screenpos.left = Math.round(screenpos.left - ((feature.width() - relativeTo.width()) / 2) - scrlLeft);
        } else {
            screenpos.left = Math.round(screenpos.left - scrlLeft);
        }                     
        
        if ((paddingElement != null) && (paddingElement.length)) {
            var padLeft = getCSSPixelProperty(paddingElement, "padding-left") + 
                          getCSSPixelProperty(paddingElement, "border-left-width") + 
                          getCSSPixelProperty(feature, "border-left-width");
            var padTop =  getCSSPixelProperty(paddingElement, "padding-top") + 
                          padding + 
                          getCSSPixelProperty(feature, "border-top-width");
            screenpos.left -= padLeft;
            screenpos.top -= padTop;
        }
                                                                                             
        if (screenpos.left < 0) {
            screenpos.left = 0;
        } else if ((screenpos.left + featureWidth) > windowWidth) {
            screenpos.left = windowWidth - featureWidth; 
        }
        
        feature.css("left", screenpos.left);
        feature.css("top", screenpos.top);
    }
    
    // opens an embedded popup window for the TOC or index    
    $("div.PageHeaderGlobalLinks > span.PageLink").click(function (e) {
        var featureId = $(this).attr("id");
        var featureContentId = $(this).attr("data-content-id");
        var featureFile = $(this).find("a").attr("href");

        if ((typeof(featureId) === "undefined") ||
            (typeof(featureContentId) === "undefined") ||
            (typeof(featureFile) === "undefined")) {
            return;
        }

        var feature = $("div.EmbeddedFeature"); 
        var container = $("div.EmbeddedFeature > div.EmbeddedFeatureContent > div.EmbeddedFeatureContentContainer");
        
        if (!(feature.length || container.length)) {
           return;
        }

        if ((featureFile != "") && (featureContentId != "")) {
            e.preventDefault();
            
            var background = $("div.EmbeddedFeatureBackground");
            var title = $("div.EmbeddedFeature > div.EmbeddedFeatureTitle");
            
            placePopupFeature(feature, $(this), true, null);
            title.html($(this).attr("title"));
    
            feature.show();
            background.show();
            
            if ((featureFile != "") && (lastEmbeddedFeatureContentFilename != featureFile)) {
                container.html("");
    
                $.ajax({
                    url: featureFile,
                    dataType: "html",
                    error: function(jqXHR, textStatus, errorThrown) {
                        container.html("Error loading " + featureFile + " (" + jqXHR.status + "): " + textStatus + " " + jqXHR.responseText );
                        // if the load fails (most likely due to security
                        // restrictions some browsers impose), we load the
                        // featureFile into the browser normally.
                        document.location = featureFile; 
                    },
                    success: function(html) {
                        lastEmbeddedFeatureContentFilename = featureFile;
                        var data = $("#" + featureContentId, $(html));
                        container.html(data);
        
                        if (featureId == "PageLinkContent") {
                            var element = doSynchTOCInFrame(document.location.pathname.match(/[^\/]+$/)[0], window);
                            if (element != null) {
                                var scrollpos = $(element).offset().top - container.height() / 2; 
                                feature.scrollTop(scrollpos);
                            }
                        } else if (featureId == "PageLinkIndex") {
                            $("#indexSearchNameField").focus();
                        }
                    }
                });
            }
        }
    });
    
    // Close the popup feature in response to the close button being clicked 
    $("div.EmbeddedFeature > div.EmbeddedFeatureClose").click(function () {
        closeEmbeddedFeature();
    });
    
    // Close the popup feature in response to the background being clicked 
    $("div.EmbeddedFeatureBackground").click(function () {
        closeEmbeddedFeature();
    });
    
    // Switchs selected section tabs 
    $("div.TabbedSectionContainer > div.SectionTabs > div").click(function () {
        var tabs = $(this).closest("div.SectionTabs");
        var container = $(this).closest("div.TabbedSectionContainer");
        var allSections = container.find(".TabbedSectionContent");

        var tabsetid = tabs.attr("id");
        var tabidx = $(this).index();
        var tabcount = allSections.length;  
        
        switchTabs(tabsetid, tabidx, tabcount);
    });

    // Toggles navigation section categories in response to checkbox selection/deselection 
    $("div.TableCategories > label.TableCategory > input").click(function () {
        var id = $(this).attr("value");
        var checked = $(this).prop("checked");
        
        setCategoryVisibility(id, checked);
    });

    // Close any popup when the user presses the ESC key
    $(document).keyup(function(e) {
        if (e.keyCode == 27) { 
            closeEmbeddedFeature();
        }
    });
    
    
    // Shows a section popup 
    $("span[data-content-id].PopupLink").click(function() {
        var featureContentId = $(this).attr("data-content-id");
        var feature = $("div#" + featureContentId);
        var background = $("div.EmbeddedFeatureBackground");
        
        placePopupFeature(feature, $(this), false, null);
        
        feature.show();
        background.show();
    });
    
    // Shows a topic path item's popup 
    $("span[data-content-id].TopicPathEntry").on('click', function(e) {
        e.preventDefault();
                                                              
        var featureContentId = $(this).attr("data-content-id");
        var feature = $("div#" + featureContentId);
        var background = $("div.EmbeddedFeatureBackground");

        var itemsContainer = feature.children("div.TopicPathPopup");
        var firstItem = itemsContainer.children("div").first();
        var selectedItem = itemsContainer.children("div.TopicPathPopupItemOnPath");
        
        placePopupFeature(feature, $(this), false, firstItem);

        feature.show();
        background.show();

        // scroll the highlighted item into view
        var featureHeight = feature.height();
        var scrollpos = Math.round(feature.scrollTop() + selectedItem.position().top - (featureHeight - selectedItem.height()) * 0.5);
        if (scrollpos > featureHeight) { 
            feature.scrollTop(scrollpos);
        }

    });
    
    // Browse to https://www.doc-o-matic.com  
    $("div.madewith_dom > img").click( function () {
        window.open("https://www.doc-o-matic.com/en");
    });

});


$( window ).on('load', function() {
    checkFixedHeaderHeight();
    loadCollapseStates();
    restoreTabbedSectionStates();
    setCategoryVisibility(null, true);
    fitTopicPath();

    if ($("body.WelcomeBody").length) {    
       fadeInWelcomeControls();
    }
    
});
