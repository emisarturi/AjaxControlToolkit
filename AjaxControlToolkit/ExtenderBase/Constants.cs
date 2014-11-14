namespace AjaxControlToolkit {
    internal static class Constants {
        internal const string
            JsPostfix = ".js",
            DebugJsPostfix = ".debug" + JsPostfix,

            CssPostfix = ".css",
            MinCssPostfix = ".min" + CssPostfix,

            IconPostfix = ".ico",

            ContentVirtualPath = "~/Content/AjaxControlToolkit/",
            StylesVirtualPath = ContentVirtualPath + "Styles/",
            ImagesVirtualPath = ContentVirtualPath + "Images/",
            ScriptsVirtualPath = "~/Scripts/AjaxControlToolkit/",
            ScriptsDebugVirtualPath = ScriptsVirtualPath + "Debug/",
            ScriptsReleaseVirtualPath = ScriptsVirtualPath + "Release/",

            ImageResourcePrefix = "AjaxControlToolkit.Images.",
            StyleResourcePrefix = "AjaxControlToolkit.Styles.",

            BackgroundStylesName = "Backgrounds",
            BaseScriptName = "BaseScripts",
            CommonScriptName = "Common",
            CompatDragDropScriptName = "Compat.DragDrop",
            CompatTimerScriptName = "Compat.Timer",
            ComponentSetName = "ComponentSet",
            DateTimeScriptName = "Common.DateTime",
            LocalizationScriptName = "Localization.Resources",
            ThreadingScriptName = "Common.Threading",

            AccordionName = "Accordion",
            AjaxFileUploadName = "AjaxFileUpload",
            AlwaysVisibleControlName = "AlwaysVisibleControl",
            AnimationName = "Animation",
            AnimationScriptsName = "AnimationScripts",
            AreaChartName = "AreaChart",
            AsyncFileUploadName = "AsyncFileUpload",
            AutoCompleteName = "AutoComplete",
            BalloonPopupName = "BalloonPopup",
            BarChartName = "BarChart",
            BubbleChartName = "BubbleChart",
            CalendarName = "Calendar",
            CascadingDropDownName = "CascadingDropDown",
            CollapsiblePanelName = "CollapsiblePanel",
            ColorPickerName = "ColorPicker",
            ConfirmButtonName = "ConfirmButton",
            ComboBoxName = "ComboBox",
            DynamicPopulateName = "DynamicPopulate",
            DraggableListItemName = "DraggableListItem",
            DragPanelName = "DragPanel",
            DropDownName = "DropDown",
            DropShadowName = "DropShadow",
            DropWatcherName = "DropWatcher",
            FilteredTextBoxName = "FilteredTextBox",
            GravatarName = "Gravatar",
            HoverMenuName = "HoverMenu",
            HoverName = "Hover",
            HtmlEditorExtenderName = "HtmlEditorExtender",
            LineChartName = "LineChart",
            ListSearchName = "ListSearch",
            MaskedEditName = "MaskedEdit",
            MaskedEditValidatorName = "MaskedEditValidator",
            ModalPopup = "ModalPopup",
            MultiHandleSliderName = "MultiHandleSlider",
            MutuallyExclusiveCheckBoxName = "MutuallyExclusiveCheckBox",
            NoBotName = "NoBot",
            NumericUpDownName = "NumericUpDown",
            PagingBulletedListName = "PagingBulletedList",
            PasswordStrengthName = "PasswordStrength",
            PieChartName = "PieChart",
            PopupControlName = "PopupControl",
            PopupName = "Popup",
            RatingName = "Rating",
            ReorderListName = "ReorderList",
            ResizableControlName = "ResizableControl",
            RoundedCornersName = "RoundedCorners",
            SeadragonName = "Seadragon",
            SliderName = "Slider",
            SlideShowName = "SlideShow",
            TabsName = "Tabs",
            TextBoxWatermarkName = "TextBoxWatermark",
            ToggleButtonName = "ToggleButton",
            TwitterName = "Twitter",
            UpdatePanelAnimationName = "UpdatePanelAnimation",
            ValidatorCalloutName = "ValidatorCallout",

            AsyncFileUploadImage = AsyncFileUploadName + ".png",

            HtmlEditorName = "HtmlEditor",
            HtmlEditorPopupsName = HtmlEditorName + ".Popups",
            HtmlEditorToolbarButtonsName = HtmlEditorName + ".ToolbarButtons",
            HtmlEditorHtmlEditorName = HtmlEditorName + ".HtmlEditor",

            HtmlEditorEditorName = HtmlEditorName + ".Editor",
            HtmlEditorToolbarName = HtmlEditorName + ".Toolbar",
            HtmlEditorEnumsName = HtmlEditorName + ".Enums",
            HtmlEditorEventsName = HtmlEditorName + ".Events",
            HtmlEditorPreviewPanelName = HtmlEditorName + ".PreviewPanel",
            HtmlEditorModePanelName = HtmlEditorName + ".ModePanel",
            HtmlEditorEditPanelName = HtmlEditorName + ".EditPanel",
            HtmlEditorHtmlPanelName = HtmlEditorName + ".HtmlPanel",
            HtmlEditorDocumentName = HtmlEditorName + ".Document",
            HtmlEditorDesignPanelName = HtmlEditorName + ".DesignPanel",
            HtmlEditorExecCommandEmulationName = HtmlEditorName + ".ExecCommandEmulation",
            HtmlEditorDesignPanelEventHandlerName = HtmlEditorName + ".DesignPanelEventHandler",

            HtmlEditorPopupName = HtmlEditorPopupsName + ".Popup",
            HtmlEditorAttachedTemplatePopupName = HtmlEditorPopupsName + ".AttachedTemplatePopup",
            HtmlEditorAttachedPopupName = HtmlEditorPopupsName + ".AttachedPopup",
            HtmlEditorPopupCommandButtonName = HtmlEditorPopupsName + ".PopupCommonButton",
            HtmlEditorPopupBoxButtonName = HtmlEditorPopupsName + ".PopupBoxButton",
            HtmlEditorPopupBGIButtonName = HtmlEditorPopupsName + ".PopupBGIButton",
            HtmlEditorOkCancelAttachedTemplatePopupName = HtmlEditorPopupsName + ".OkCancelAttachedTemplatePopup",
            HtmlEditorLinkPropertiesName = HtmlEditorPopupsName + ".LinkProperties",
            HtmlEditorBaseColorsPopupName = HtmlEditorPopupsName + ".BaseColorsPopup",

            HtmlEditorBackColorClearButtonName = HtmlEditorToolbarButtonsName + ".BackColorClear",
            HtmlEditorBackColorSelectorButtonName = HtmlEditorToolbarButtonsName + ".BackColorSelector",
            HtmlEditorBoldButtonName = HtmlEditorToolbarButtonsName + ".Bold",
            HtmlEditorBoxButtonName = HtmlEditorToolbarButtonsName + ".BoxButton",
            HtmlEditorBulletedListButtonName = HtmlEditorToolbarButtonsName + ".BulletedList",
            HtmlEditorColorButtonName = HtmlEditorToolbarButtonsName + ".ColorButton",
            HtmlEditorColorSelectorName = HtmlEditorToolbarButtonsName + ".ColorSelector",
            HtmlEditorCommonButtonName = HtmlEditorToolbarButtonsName + ".CommonButton",
            HtmlEditorCopyButtonName = HtmlEditorToolbarButtonsName + ".Copy",
            HtmlEditorCutButtonName = HtmlEditorToolbarButtonsName + ".Cut",
            HtmlEditorDecreaseIndentButtonName = HtmlEditorToolbarButtonsName + ".DecreaseIndent",
            HtmlEditorDesignModeButtonName = HtmlEditorToolbarButtonsName + ".DesignMode",
            HtmlEditorDesignModeBoxButtonName = HtmlEditorToolbarButtonsName + ".DesignModeBoxButton",
            HtmlEditorDesignModeImageButtonName = HtmlEditorToolbarButtonsName + ".DesignModeImageButton",
            HtmlEditorDesignModePopupImageButtonName = HtmlEditorToolbarButtonsName + ".DesignModePopupImageButton",
            HtmlEditorDesignModeSelectButtonName = HtmlEditorToolbarButtonsName + ".DesignModeSelectButton",
            HtmlEditorToggleButtonName = HtmlEditorToolbarButtonsName + ".EditorToggleButton",
            HtmlEditorFixedBackColorButtonName = HtmlEditorToolbarButtonsName + ".FixedBackColor",
            HtmlEditorFixedColorButtonName = HtmlEditorToolbarButtonsName + ".FixedColorButton",
            HtmlEditorFixedForeColorButtonName = HtmlEditorToolbarButtonsName + ".FixedForeColor",
            HtmlEditorFontNameButtonName = HtmlEditorToolbarButtonsName + ".FontName",
            HtmlEditorFontSizeButtonName = HtmlEditorToolbarButtonsName + ".FontSize",
            HtmlEditorForeColorButtonName = HtmlEditorToolbarButtonsName + ".ForeColor",
            HtmlEditorForeColorClearButtonName = HtmlEditorToolbarButtonsName + ".ForeColorClear",
            HtmlEditorForeColorSelectorButtonName = HtmlEditorToolbarButtonsName + ".ForeColorSelector",
            HtmlEditorHorizontalSepearatorButtonName = HtmlEditorToolbarButtonsName + ".HorizontalSeparator",
            HtmlEditorHtmlModeButtonName = HtmlEditorToolbarButtonsName + ".HtmlMode",
            HtmlEditorImageButtonName = HtmlEditorToolbarButtonsName + ".ImageButton",
            HtmlEditorIncreaseIndentButtonName = HtmlEditorToolbarButtonsName + ".IncreaseIndent",
            HtmlEditorInsertHRButtonName = HtmlEditorToolbarButtonsName + ".InsertHR",
            HtmlEditorInsertLinkButtonName = HtmlEditorToolbarButtonsName + ".InsertLink",
            HtmlEditorItalicButtonName = HtmlEditorToolbarButtonsName + ".Italic",
            HtmlEditorJustifyCenterButtonName = HtmlEditorToolbarButtonsName + ".JustifyCenter",
            HtmlEditorJustifyFullButtonName = HtmlEditorToolbarButtonsName + ".JustifyFull",
            HtmlEditorJustifyRightButtonName = HtmlEditorToolbarButtonsName + ".JustifyRight",
            HtmlEditorJustifyLeftButtonName = HtmlEditorToolbarButtonsName + ".JustifyLeft",
            HtmlEditorLtrButtonName = HtmlEditorToolbarButtonsName + ".Ltr",
            HtmlEditorMethodButtonName = HtmlEditorToolbarButtonsName + ".MethodButton",
            HtmlEditorModeButtonName = HtmlEditorToolbarButtonsName + ".ModeButton",
            HtmlEditorOkCancelPopupButtonName = HtmlEditorToolbarButtonsName + ".OkCancelPopupButton",
            HtmlEditorOrderedListButtonName = HtmlEditorToolbarButtonsName + ".OrderedList",
            HtmlEditorParagraphButtonName = HtmlEditorToolbarButtonsName + ".Paragraph",
            HtmlEditorPasteButtonName = HtmlEditorToolbarButtonsName + ".Paste",
            HtmlEditorPasteTextButtonName = HtmlEditorToolbarButtonsName + ".PasteText",
            HtmlEditorPasteWordButtonName = HtmlEditorToolbarButtonsName + ".PasteWord",
            HtmlEditorPreviewModeButtonName = HtmlEditorToolbarButtonsName + ".PreviewMode",
            HtmlEditorRedoButtonMode = HtmlEditorToolbarButtonsName + ".Redo",
            HtmlEditorRemoveAlignmentButtonName = HtmlEditorToolbarButtonsName + ".RemoveAlignment",
            HtmlEditorRemoveLinkButtonName = HtmlEditorToolbarButtonsName + ".RemoveLink",
            HtmlEditorRemoveStylesButtonName = HtmlEditorToolbarButtonsName + ".RemoveStyles",
            HtmlEditorRtlButtonName = HtmlEditorToolbarButtonsName + ".Rtl",
            HtmlEditorSelectButtonName = HtmlEditorToolbarButtonsName + ".SelectButton",
            HtmlEditorSelectorButtonName = HtmlEditorToolbarButtonsName + ".Selector",
            HtmlEditorStrikeThroughButtonName = HtmlEditorToolbarButtonsName + ".StrikeThrough",
            HtmlEditorSubScriptButtonName = HtmlEditorToolbarButtonsName + ".SubScript",
            HtmlEditorSuperScriptButtonName = HtmlEditorToolbarButtonsName + ".SuperScript",
            HtmlEditorUnderlineButtonName = HtmlEditorToolbarButtonsName + ".Underline",
            HtmlEditorUndoButtonName = HtmlEditorToolbarButtonsName + ".Undo",

            HtmlEditorBgiButtonImage = HtmlEditorName + "-BgiButton.gif",
            HtmlEditorEdColorBgClearNImage = HtmlEditorName + "-EdColorBgClearN.gif",
            HtmlEditorEdColorBgClearAImage = HtmlEditorName + "-EdColorBgClearA.gif",
            HtmlEditorEdFormatBoldAImage = HtmlEditorName + "-EdFormatBoldA.gif",
            HtmlEditorEdFormatBoldNImage = HtmlEditorName + "-EdFormatBoldN.gif",
            HtmlEditorEdListBulletAImage = HtmlEditorName + "-EdListBulletA.gif",
            HtmlEditorEdListBulletNImage = HtmlEditorName + "-EdListBulletN.gif",
            HtmlEditorEdCopyAImage = HtmlEditorName + "-EdCopyA.gif",
            HtmlEditorEdCopyNImage = HtmlEditorName + "-EdCopyN.gif",
            HtmlEditorEdCutAImage = HtmlEditorName + "-EdCutA.gif",
            HtmlEditorEdCutNImage = HtmlEditorName + "-EdCutN.gif",
            HtmlEditorEdIndentLessAImage = HtmlEditorName + "-EdIndentLessA.gif",
            HtmlEditorEdIndentLessNImage = HtmlEditorName + "-EdIndentLessN.gif",
            HtmlEditorEdDesignAImage = HtmlEditorName + "-EdDesignA.gif",
            HtmlEditorEdDesignNImage = HtmlEditorName + "-EdDesignN.gif",
            HtmlEditorEdBackColorAImage = HtmlEditorName + "-EdBackColorA.gif",
            HtmlEditorEdBackColorNImage = HtmlEditorName + "-EdBackColorN.gif",
            HtmlEditorEdForeColorAImage = HtmlEditorName + "-EdForeColorA.gif",
            HtmlEditorEdForeColorNImage = HtmlEditorName + "-EdForeColorN.gif",
            HtmlEditorEdColorFgAImage = HtmlEditorName + "-EdColorFgA.gif",
            HtmlEditorEdColorFgNImage = HtmlEditorName + "-EdColorFgN.gif",
            HtmlEditorEdColorFgClearAImage = HtmlEditorName + "-EdColorFgClearA.gif",
            HtmlEditorEdColorFgClearNImage = HtmlEditorName + "-EdColorFgClearN.gif",
            HtmlEditorEdSepImage = HtmlEditorName + "-EdSep.gif",
            HtmlEditorEdHtmlAImage = HtmlEditorName + "-EdHtmlA.gif",
            HtmlEditorEdHtmlNImage = HtmlEditorName + "-EdHtmlN.gif",
            HtmlEditorEdIndentMoreAImage = HtmlEditorName + "-EdIndentMoreA.gif",
            HtmlEditorEdIndentMoreNImage = HtmlEditorName + "-EdIndentMoreN.gif",
            HtmlEditorEdRuleAImage = HtmlEditorName + "-EdRuleA.gif",
            HtmlEditorEdRuleNImage = HtmlEditorName + "-EdRuleN.gif",
            HtmlEditorEdLinkAImage = HtmlEditorName + "-EdLinkA.gif",
            HtmlEditorEdLinkNImage = HtmlEditorName + "-EdLinkN.gif",
            HtmlEditorEdFormatItalicAImage = HtmlEditorName + "-EdFormatItalicA.gif",
            HtmlEditorEdFormatItalicNImage = HtmlEditorName + "-EdFormatItalicN.gif",
            HtmlEditorEdAlingCenterAImage = HtmlEditorName + "-EdAlignCenterA.gif",
            HtmlEditorEdAlingCenterNImage = HtmlEditorName + "-EdAlignCenterN.gif",
            HtmlEditorEdAlignJustifyAImage = HtmlEditorName + "-EdAlignJustifyA.gif",
            HtmlEditorEdAlignJustifyNImage = HtmlEditorName + "-EdAlignJustifyN.gif",
            HtmlEditorEdAlignLeftAImage = HtmlEditorName + "-EdAlignLeftA.gif",
            HtmlEditorEdAlignLeftNImage = HtmlEditorName + "-EdAlignLeftN.gif",
            HtmlEditorEdAlignRightAImage = HtmlEditorName + "-EdAlignRightA.gif",
            HtmlEditorEdAlignRightNImage = HtmlEditorName + "-EdAlignRightN.gif",
            HtmlEditorEdFormatLtrAImage = HtmlEditorName + "-EdFormatLtrA.gif",
            HtmlEditorEdFormatLtrNImage = HtmlEditorName + "-EdFormatLtrN.gif",
            HtmlEditorEdListNumAImage = HtmlEditorName + "-EdListNumA.gif",
            HtmlEditorEdListNumNImage = HtmlEditorName + "-EdListNumN.gif",
            HtmlEditorEdFormatParagraphAImage = HtmlEditorName + "-EdFormatParagraphA.gif",
            HtmlEditorEdFormatParagraphNImage = HtmlEditorName + "-EdFormatParagraphN.gif",
            HtmlEditorEdPasteAImage = HtmlEditorName + "-EdPasteA.gif",
            HtmlEditorEdPasteNImage = HtmlEditorName + "-EdPasteN.gif",
            HtmlEditorEdPasteTextAImage = HtmlEditorName + "-EdPasteTextA.gif",
            HtmlEditorEdPasteTextNImage = HtmlEditorName + "-EdPasteTextN.gif",
            HtmlEditorEdPasteWordAImage = HtmlEditorName + "-EdPasteWordA.gif",
            HtmlEditorEdPasteWordNImage = HtmlEditorName + "-EdPasteWordN.gif",
            HtmlEditorEdPreviewAImage = HtmlEditorName + "-EdPreviewA.gif",
            HtmlEditorEdPreviewNImage = HtmlEditorName + "-EdPreviewN.gif",
            HtmlEditorEdRedoAImage = HtmlEditorName + "-EdRedoA.gif",
            HtmlEditorEdRedoNImage = HtmlEditorName + "-EdRedoN.gif",
            HtmlEditorEdRemoveAlignAImage = HtmlEditorName + "-EdRemoveAlignA.gif",
            HtmlEditorEdRemoveAlignNImage = HtmlEditorName + "-EdRemoveAlignN.gif",
            HtmlEditorEdUnlinkAImage = HtmlEditorName + "-EdUnlinkA.gif",
            HtmlEditorEdUnlinkNImage = HtmlEditorName + "-EdUnlinkN.gif",
            HtmlEditorEdUnformatAImage = HtmlEditorName + "-EdUnformatA.gif",
            HtmlEditorEdUnformatNImage = HtmlEditorName + "-EdUnformatN.gif",
            HtmlEditorEdFormatRtlAImage = HtmlEditorName + "-EdFormatRtlA.gif",
            HtmlEditorEdFormatRtlNImage = HtmlEditorName + "-EdFormatRtlN.gif",
            HtmlEditorEdSelectorAImage = HtmlEditorName + "-EdSelectorA.gif",
            HtmlEditorEdSelectorNImage = HtmlEditorName + "-EdSelectorN.gif",
            HtmlEditorEdFormatStrikeAImage = HtmlEditorName + "-EdFormatStrikeA.gif",
            HtmlEditorEdFormatStrikeNImage = HtmlEditorName + "-EdFormatStrikeN.gif",
            HtmlEditorEdFormatSubAImage = HtmlEditorName + "-EdFormatSubA.gif",
            HtmlEditorEdFormatSubNImage = HtmlEditorName + "-EdFormatSubN.gif",
            HtmlEditorEdFormatSupAImage = HtmlEditorName + "-EdFormatSupA.gif",
            HtmlEditorEdFormatSupNImage = HtmlEditorName + "-EdFormatSupN.gif",
            HtmlEditorEdFormatUnderlineAImage = HtmlEditorName + "-EdFormatUnderlineA.gif",
            HtmlEditorEdFormatUnderlineNImage = HtmlEditorName + "-EdFormatUnderlineN.gif",
            HtmlEditorEdUndoAImage = HtmlEditorName + "-EdUndoA.gif",
            HtmlEditorEdUndoNImage = HtmlEditorName + "-EdUndoN.gif",
            HtmlEditorEd1x1Image = HtmlEditorName + "-Ed1x1.gif",
            HtmlEditorEdAnchorImage = HtmlEditorName + "-EdAnchor.gif",
            HtmlEditorEdFlashImage = HtmlEditorName + "-EdFlash.gif",
            HtmlEditorEdMediaImage = HtmlEditorName + "-EdMedia.gif",
            HtmlEditorEdPlaceHolderImage = HtmlEditorName + "-EdPlaceHolder.gif",

            BalloonPopupCloudGifSprite = BalloonPopupName + "Cloud-Sprite.gif",
            BalloonPopupCloudPngSprite = BalloonPopupName + "Cloud-Sprite.png",
            BalloonPopupRectangleGifSprite = BalloonPopupName + "Rectangle-Sprite.gif",
            BalloonPopupRectanglePngSprite = BalloonPopupName + "Rectangle-Sprite.png",
            CalendarArrowLeftImage = CalendarName + "Arrow-Left.gif",
            CalendarArrowRightImage = CalendarName + "Arrow-Right.gif",
            ComboBoxArrowDownImage = ComboBoxName + "Arrow-Down.gif",
            DropDownDropArrowImage = DropDownName + "Drop-Arrow.gif",
            GravatarAnonymousImage = GravatarName + "-Anonymous.jpg",
            GravatarGImage = GravatarName + "-G.jpg",
            GravatarPGImage = GravatarName + "-PG.jpg",
            GravatarRImage = GravatarName + "-R.jpg",
            GravatarXImage = GravatarName + "-X.jpg",
            MultiHandleSliderHHandleImage = MultiHandleSliderName + "-HHandle.gif",
            MultiHandleSliderHHandleDownImage = MultiHandleSliderName + "-HHandleDown.gif",
            MultiHandleSliderHHandleHoverImage = MultiHandleSliderName + "-HHandleHover.gif",
            MultiHandleSliderHRailImage = MultiHandleSliderName + "-HRail.gif",
            MultiHandleSliderHRailOuterImage = MultiHandleSliderName + "-HRailOuter.gif",
            MultiHandleSliderVHandleImage = MultiHandleSliderName + "-VHandle.gif",
            MultiHandleSliderVHandleDownImage = MultiHandleSliderName + "-VHandleDown.gif",
            MultiHandleSliderVHandleHoverImage = MultiHandleSliderName + "-VHandleHover.gif",
            MultiHandleSliderVRailImage = MultiHandleSliderName + "-VRail.gif",
            MultiHandleSliderVRailOuterImage = MultiHandleSliderName + "-VRailOuter.gif",
            SeadragonFullpageGrouphoverImage = SeadragonName + "Fullpage-Grouphover.png",
            SeadragonFullpageHoverImage = SeadragonName + "Fullpage-Hover.png",
            SeadragonFullpagePressedImage = SeadragonName + "Fullpage-Pressed.png",
            SeadragonFullpageRestImage = SeadragonName + "Fullpage-Rest.png",
            SeadragonHomeGrouphoverImage = SeadragonName + "Home-Grouphover.png",
            SeadragonHomeHoverImage = SeadragonName + "Home-Hover.png",
            SeadragonHomePressedImage = SeadragonName + "Home-Pressed.png",
            SeadragonHomeRestImage = SeadragonName + "Home-Rest.png",
            SeadragonZoominGrouphoverImage = SeadragonName + "Zoomin-Grouphover.png",
            SeadragonZoominHoverImage = SeadragonName + "Zoomin-Hover.png",
            SeadragonZoominPressedImage = SeadragonName + "Zoomin-Pressed.png",
            SeadragonZoominRestImage = SeadragonName + "Zoomin-Rest.png",
            SeadragonZoomoutGrouphoverImage = SeadragonName + "Zoomout-Grouphover.png",
            SeadragonZoomoutHoverImage = SeadragonName + "Zoomout-Hover.png",
            SeadragonZoomoutPressedImage = SeadragonName + "Zoomout-Pressed.png",
            SeadragonZoomoutRestImage = SeadragonName + "Zoomout-Rest.png",
            SliderVerticalRailImage = SliderName + "Rail-V.gif",
            SliderHorizontalRailImage = SliderName + "Rail-H.gif",
            SliderVerticalHandleImage = SliderName + "Handle-V.gif",
            SliderHorizontalHandleImage = SliderName + "Handle-H.gif",
            TabsImage = TabsName + ".gif",
            TabsActiveLeftVerticalleftImage = TabsName + "Active-Left-Verticalleft.gif",
            TabsActiveLeftVerticalrightImage = TabsName + "Active-Left-Verticalright.gif",
            TabsActiveLeftImage = TabsName + "Active-Left.gif",
            TabsActiveRightVerticallefImage = TabsName + "Active-Right-Verticalleft.gif",
            TabsActiveRightVerticalrightImage = TabsName + "Active-Right-Verticalright.gif",
            TabsActiveRightImage = TabsName + "Active-Right.gif",
            TabsActiveVerticalleftImage = TabsName + "Active-Verticalleft.gif",
            TabsActiveVerticalrightImage = TabsName + "Active-Verticalright.gif",
            TabsActiveImage = TabsName + "Active.gif",
            TabsBottomActiveLeftImage = TabsName + "Bottom-Active-Left.gif",
            TabsBottomActiveRightImage = TabsName + "Bottom-Active-Right.gif",
            TabsBottomActiveImage = TabsName + "Bottom-Active.gif",
            TabsBottomHoverLeftImage = TabsName + "Bottom-Hover-Left.gif",
            TabsBottomHoverRightImage = TabsName + "Bottom-Hover-Right.gif",
            TabsBottomHoverImage = TabsName + "Bottom-Hover.gif",
            TabsBottomLeftImage = TabsName + "Bottom-Left.gif",
            TabsBottomRightImage = TabsName + "Bottom-Right.gif",
            TabsBottomImage = TabsName + "Bottom.gif",
            TabsHoverLeftVerticalleftImage = TabsName + "Hover-Left-Verticalleft.gif",
            TabsHoverLeftVerticalrightImage = TabsName + "Hover-Left-Verticalright.gif",
            TabsHoverLeftImage = TabsName + "Hover-Left.gif",
            TabsHoverRightVerticalleftImage = TabsName + "Hover-Right-Verticalleft.gif",
            TabsHoverRightVerticalrightImage = TabsName + "Hover-Right-Verticalright.gif",
            TabsHoverRightImage = TabsName + "Hover-Right.gif",
            TabsHoverVerticalleftImage = TabsName + "Hover-Verticalleft.gif",
            TabsHoverVerticalrightImage = TabsName + "Hover-Verticalright.gif",
            TabsHoverImage = TabsName + "Hover.gif",
            TabsLeftVerticalleftImage = TabsName + "Left-Verticalleft.gif",
            TabsLeftVerticalrightImage = TabsName + "Left-Verticalright.gif",
            TabsLeftImage = TabsName + "Left.gif",
            TabsLineImage = TabsName + "Line.gif",
            TabsRightVerticalleftImage = TabsName + "Right-Verticalleft.gif",
            TabsRightVerticalrightImage = TabsName + "Right-Verticalright.gif",
            TabsRightImage = TabsName + "Right.gif",
            TabsVerticalleftImage = TabsName + "Verticalleft.gif",
            TabsVerticalrightImage = TabsName + "Verticalright.gif",
            Twitter24Image = TwitterName + "24.png",
            Twitter32Image = TwitterName + "32.png",
            ValidatorCalloutAlertLargeImage = ValidatorCalloutName + "Alert-Large.gif",
            ValidatorCalloutAlertSmallImage = ValidatorCalloutName + "Alert-Small.gif",
            ValidatorCalloutCloseImage = ValidatorCalloutName + "Close.gif";
    }
}
