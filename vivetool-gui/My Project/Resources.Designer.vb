﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("ViVeTool_GUI.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property about() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("about", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Closes the Dialog.
        '''</summary>
        Friend ReadOnly Property Comments_ClosesTheDialog() As String
            Get
                Return ResourceManager.GetString("Comments_ClosesTheDialog", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Your Comment was sent successfully..
        '''</summary>
        Friend ReadOnly Property Comments_CommentSentSuccessfully() As String
            Get
                Return ResourceManager.GetString("Comments_CommentSentSuccessfully", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to I Agree.
        '''</summary>
        Friend ReadOnly Property Comments_I_Agree() As String
            Get
                Return ResourceManager.GetString("Comments_I_Agree", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to I Dont Agree.
        '''</summary>
        Friend ReadOnly Property Comments_I_Dont_Agree() As String
            Get
                Return ResourceManager.GetString("Comments_I_Dont_Agree", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Close this Dialog and don&apos;t send anything.
        '''</summary>
        Friend ReadOnly Property Comments_I_Dont_Agree_Subtext() As String
            Get
                Return ResourceManager.GetString("Comments_I_Dont_Agree_Subtext", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Privacy Information.
        '''</summary>
        Friend ReadOnly Property Comments_PrivacyInformation() As String
            Get
                Return ResourceManager.GetString("Comments_PrivacyInformation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Before you can send your comment, you have to agree, that the following Information will be saved indefinitely in a Database:
        '''
        '''Selected Build, Selected ViVeTool Feature, Your Comment
        '''
        '''You also have to agree, that your IP Address will be encrypted and stored for 24 Hours after pressing on &apos;Send Comment&apos;.
        '''
        '''Storing of your IP Address for 24 Hours is a security precaution to prevent Spam and Abuse..
        '''</summary>
        Friend ReadOnly Property Comments_PrivacyText() As String
            Get
                Return ResourceManager.GetString("Comments_PrivacyText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Sending your Comment….
        '''</summary>
        Friend ReadOnly Property Comments_SendingYourComment() As String
            Get
                Return ResourceManager.GetString("Comments_SendingYourComment", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Send my comment.
        '''</summary>
        Friend ReadOnly Property Comments_SendMyComment() As String
            Get
                Return ResourceManager.GetString("Comments_SendMyComment", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  Comment Sent.
        '''</summary>
        Friend ReadOnly Property Comments_Spaced_CommentSent() As String
            Get
                Return ResourceManager.GetString("Comments_Spaced_CommentSent", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  Privacy Information.
        '''</summary>
        Friend ReadOnly Property Comments_Spaced_PrivacyInformation() As String
            Get
                Return ResourceManager.GetString("Comments_Spaced_PrivacyInformation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  Sending your Comment….
        '''</summary>
        Friend ReadOnly Property Comments_Spaced_SendingYourComment() As String
            Get
                Return ResourceManager.GetString("Comments_Spaced_SendingYourComment", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to A Network Error occurred.
        '''</summary>
        Friend ReadOnly Property Error_ANetworkErrorOccurred() As String
            Get
                Return ResourceManager.GetString("Error_ANetworkErrorOccurred", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to A Network Exception occurred.
        '''</summary>
        Friend ReadOnly Property Error_ANetworkExceptionOccurred() As String
            Get
                Return ResourceManager.GetString("Error_ANetworkExceptionOccurred", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An unknown Exception occurred.
        '''</summary>
        Friend ReadOnly Property Error_AnUnknownExceptionOccurred() As String
            Get
                Return ResourceManager.GetString("Error_AnUnknownExceptionOccurred", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Collapse Exception.
        '''</summary>
        Friend ReadOnly Property Error_CollapseException() As String
            Get
                Return ResourceManager.GetString("Error_CollapseException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Copies the Exception to the Clipboard and closes the dialog.
        '''</summary>
        Friend ReadOnly Property Error_CopyExceptionAndClose_ToolTip() As String
            Get
                Return ResourceManager.GetString("Error_CopyExceptionAndClose_ToolTip", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error.
        '''</summary>
        Friend ReadOnly Property Error_Error() As String
            Get
                Return ResourceManager.GetString("Error_Error", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An Exception occurred while trying to set Feature ID {0} to {1}.
        '''</summary>
        Friend ReadOnly Property Error_ExceptionSettingFeatureID() As String
            Get
                Return ResourceManager.GetString("Error_ExceptionSettingFeatureID", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An Error occurred while trying to start the ViVeTool GUI Feature Scanner.
        '''
        '''The File doesn&apos;t exist..
        '''</summary>
        Friend ReadOnly Property Error_FeatureScannerNotFound_N() As String
            Get
                Return ResourceManager.GetString("Error_FeatureScannerNotFound_N", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An Error occurred while trying to start the ViVeTool GUI Feature Scanner..
        '''</summary>
        Friend ReadOnly Property Error_FeatureScannerNotFound1_ToBeMigrated() As String
            Get
                Return ResourceManager.GetString("Error_FeatureScannerNotFound1_ToBeMigrated", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The File doesn&apos;t exist..
        '''</summary>
        Friend ReadOnly Property Error_FeatureScannerNotFound2_ToBeMigrated() As String
            Get
                Return ResourceManager.GetString("Error_FeatureScannerNotFound2_ToBeMigrated", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to A generic Win32 Exception occurred..
        '''</summary>
        Friend ReadOnly Property Error_GenericWin32Exception_Heading() As String
            Get
                Return ResourceManager.GetString("Error_GenericWin32Exception_Heading", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to There could be multiple causes for Win32 Exceptions, but they usually narrow down to Anti-virus Software interfering with ViVeTool GUI, or Permission problems..
        '''</summary>
        Friend ReadOnly Property Error_GenericWin32Exception_Text() As String
            Get
                Return ResourceManager.GetString("Error_GenericWin32Exception_Text", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Network Error.
        '''</summary>
        Friend ReadOnly Property Error_NetworkError() As String
            Get
                Return ResourceManager.GetString("Error_NetworkError", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Your IP may have been temporarily rate limited by the GitHub API for an hour..
        '''</summary>
        Friend ReadOnly Property Error_NetworkException_GithubAPI() As String
            Get
                Return ResourceManager.GetString("Error_NetworkException_GithubAPI", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to GitHub API Response: .
        '''</summary>
        Friend ReadOnly Property Error_NetworkException_GithubAPI_Response() As String
            Get
                Return ResourceManager.GetString("Error_NetworkException_GithubAPI_Response", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ViVeTool-GUI is unable to populate the Build Combo Box, if the Device isn&apos;t connected to the Internet, or if the GitHub API is unreachable.
        '''
        '''You are still able to manually change a Feature ID by pressing F12, and able to load a local Feature List..
        '''</summary>
        Friend ReadOnly Property Error_NetworkExceptionDetail_N() As String
            Get
                Return ResourceManager.GetString("Error_NetworkExceptionDetail_N", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ViVeTool-GUI is unable to populate the Build Combo Box, if the Device isn&apos;t connected to the Internet, or if the GitHub API is unreachable..
        '''</summary>
        Friend ReadOnly Property Error_NetworkExceptionDetail1_ToBeMigrated() As String
            Get
                Return ResourceManager.GetString("Error_NetworkExceptionDetail1_ToBeMigrated", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You are still able to manually change a Feature ID by pressing F12, and able to load a local Feature List..
        '''</summary>
        Friend ReadOnly Property Error_NetworkExceptionDetail2_ToBeMigrated() As String
            Get
                Return ResourceManager.GetString("Error_NetworkExceptionDetail2_ToBeMigrated", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Network Functions disabled. Press F12 to manually change a Feature..
        '''</summary>
        Friend ReadOnly Property Error_NetworkFunctionsDisabledF12() As String
            Get
                Return ResourceManager.GetString("Error_NetworkFunctionsDisabledF12", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Select Build 17704 or higher to use Grouping.
        '''</summary>
        Friend ReadOnly Property Error_SelectBuild17704OrHigherToUseGrouping() As String
            Get
                Return ResourceManager.GetString("Error_SelectBuild17704OrHigherToUseGrouping", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An Error occurred while sending your comment..
        '''</summary>
        Friend ReadOnly Property Error_SendComment() As String
            Get
                Return ResourceManager.GetString("Error_SendComment", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An Error occurred while trying to set {0} to {1}.
        '''</summary>
        Friend ReadOnly Property Error_SetConfig() As String
            Get
                Return ResourceManager.GetString("Error_SetConfig", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An Error occurred while setting a feature configuration for {0}.
        '''</summary>
        Friend ReadOnly Property Error_SettingFeatureConfig() As String
            Get
                Return ResourceManager.GetString("Error_SettingFeatureConfig", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Show Exception.
        '''</summary>
        Friend ReadOnly Property Error_ShowException() As String
            Get
                Return ResourceManager.GetString("Error_ShowException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  An Error occurred.
        '''</summary>
        Friend ReadOnly Property Error_Spaced_AnErrorOccurred() As String
            Get
                Return ResourceManager.GetString("Error_Spaced_AnErrorOccurred", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  A Network Error occurred.
        '''</summary>
        Friend ReadOnly Property Error_Spaced_ANetworkErrorOccurred() As String
            Get
                Return ResourceManager.GetString("Error_Spaced_ANetworkErrorOccurred", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  A Network Exception occurred.
        '''</summary>
        Friend ReadOnly Property Error_Spaced_ANetworkExceptionOccurred() As String
            Get
                Return ResourceManager.GetString("Error_Spaced_ANetworkExceptionOccurred", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  An Exception occurred.
        '''</summary>
        Friend ReadOnly Property Error_Spaced_AnExceptionOccurred() As String
            Get
                Return ResourceManager.GetString("Error_Spaced_AnExceptionOccurred", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  Unsupported Build.
        '''</summary>
        Friend ReadOnly Property Error_Spaced_UnsupportedBuild() As String
            Get
                Return ResourceManager.GetString("Error_Spaced_UnsupportedBuild", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unsupported Build.
        '''</summary>
        Friend ReadOnly Property Error_UnsupportedBuild() As String
            Get
                Return ResourceManager.GetString("Error_UnsupportedBuild", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You are running an unsupported Windows 10 Build. ViVe, ViVeTool and ViVeTool GUI require Windows 10 Build 18963 or higher to function properly. Your Build is: {0}.
        '''</summary>
        Friend ReadOnly Property Error_UnsupportedBuild_Text_N() As String
            Get
                Return ResourceManager.GetString("Error_UnsupportedBuild_Text_N", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Finish.
        '''</summary>
        Friend ReadOnly Property General_Finish() As String
            Get
                Return ResourceManager.GetString("General_Finish", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Always Disabled.
        '''</summary>
        Friend ReadOnly Property Generic_AlwaysDisabled() As String
            Get
                Return ResourceManager.GetString("Generic_AlwaysDisabled", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Always Enabled.
        '''</summary>
        Friend ReadOnly Property Generic_AlwaysEnabled() As String
            Get
                Return ResourceManager.GetString("Generic_AlwaysEnabled", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Close.
        '''</summary>
        Friend ReadOnly Property Generic_Close() As String
            Get
                Return ResourceManager.GetString("Generic_Close", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Dark Theme.
        '''</summary>
        Friend ReadOnly Property Generic_DarkTheme() As String
            Get
                Return ResourceManager.GetString("Generic_DarkTheme", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Default.
        '''</summary>
        Friend ReadOnly Property Generic_Default() As String
            Get
                Return ResourceManager.GetString("Generic_Default", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Disabled by Default.
        '''</summary>
        Friend ReadOnly Property Generic_DisabledByDefault() As String
            Get
                Return ResourceManager.GetString("Generic_DisabledByDefault", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Done..
        '''</summary>
        Friend ReadOnly Property Generic_Done() As String
            Get
                Return ResourceManager.GetString("Generic_Done", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Enabled By Default.
        '''</summary>
        Friend ReadOnly Property Generic_EnabledByDefault() As String
            Get
                Return ResourceManager.GetString("Generic_EnabledByDefault", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Feature ID.
        '''</summary>
        Friend ReadOnly Property Generic_FeatureID() As String
            Get
                Return ResourceManager.GetString("Generic_FeatureID", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Feature Name.
        '''</summary>
        Friend ReadOnly Property Generic_FeatureName() As String
            Get
                Return ResourceManager.GetString("Generic_FeatureName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Feature State.
        '''</summary>
        Friend ReadOnly Property Generic_FeatureState() As String
            Get
                Return ResourceManager.GetString("Generic_FeatureState", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Light Theme.
        '''</summary>
        Friend ReadOnly Property Generic_LightTheme() As String
            Get
                Return ResourceManager.GetString("Generic_LightTheme", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Load manually….
        '''</summary>
        Friend ReadOnly Property Generic_LoadManually() As String
            Get
                Return ResourceManager.GetString("Generic_LoadManually", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modifiable.
        '''</summary>
        Friend ReadOnly Property Generic_Modifiable() As String
            Get
                Return ResourceManager.GetString("Generic_Modifiable", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Populating the Data Grid View… This can take a while..
        '''</summary>
        Friend ReadOnly Property Generic_PopulatingTheDataGridView() As String
            Get
                Return ResourceManager.GetString("Generic_PopulatingTheDataGridView", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Select Build….
        '''</summary>
        Friend ReadOnly Property Generic_SelectBuild() As String
            Get
                Return ResourceManager.GetString("Generic_SelectBuild", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icons8_about_24() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icons8_about_24", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icons8_about_96() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icons8_about_96", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icons8_advertisement_page_24() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icons8_advertisement_page_24", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icons8_advertisement_page_96() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icons8_advertisement_page_96", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icons8_change_theme_24px() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icons8_change_theme_24px", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icons8_comments_24px() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icons8_comments_24px", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icons8_moon_and_stars_24() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icons8_moon_and_stars_24", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icons8_portrait_mode_scanning_24px() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icons8_portrait_mode_scanning_24px", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icons8_registration_24px() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icons8_registration_24px", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icons8_rollback_24() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icons8_rollback_24", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icons8_settings_system_daydream_24px() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icons8_settings_system_daydream_24px", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icons8_start_24() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icons8_start_24", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icons8_sun_24() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icons8_sun_24", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icons8_toggle_off_24() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icons8_toggle_off_24", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property icons8_toggle_on_24() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("icons8_toggle_on_24", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Path to a Feature List.
        '''</summary>
        Friend ReadOnly Property LoadManually_PathToAFeatureList() As String
            Get
                Return ResourceManager.GetString("LoadManually_PathToAFeatureList", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property main_icon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("main_icon", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Ready. Select a build from the Combo Box to get started, or alternatively press F12 to manually change a Feature..
        '''</summary>
        Friend ReadOnly Property PopulateBuildComboBox_Check_Ready() As String
            Get
                Return ResourceManager.GetString("PopulateBuildComboBox_Check_Ready", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  Success.
        '''</summary>
        Friend ReadOnly Property SetConfig_Success() As String
            Get
                Return ResourceManager.GetString("SetConfig_Success", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Successfully set Feature {0} to {1}.
        '''</summary>
        Friend ReadOnly Property SetConfig_SuccessfullySetFeature() As String
            Get
                Return ResourceManager.GetString("SetConfig_SuccessfullySetFeature", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Successfully set Feature Configuration for {0} with Value {1}.
        '''</summary>
        Friend ReadOnly Property SetConfig_SuccessfullySetFeatureConfig_Status() As String
            Get
                Return ResourceManager.GetString("SetConfig_SuccessfullySetFeatureConfig_Status", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Successfully set Feature ID {0} to {1}.
        '''</summary>
        Friend ReadOnly Property SetConfig_SuccessfullySetFeatureID() As String
            Get
                Return ResourceManager.GetString("SetConfig_SuccessfullySetFeatureID", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property settings_system_daydream() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("settings_system_daydream", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &amp;About.
        '''</summary>
        Friend ReadOnly Property SystemMenu_About() As String
            Get
                Return ResourceManager.GetString("SystemMenu_About", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Manually Set Feature ID.
        '''</summary>
        Friend ReadOnly Property SystemMenu_ManuallySetFeatureID() As String
            Get
                Return ResourceManager.GetString("SystemMenu_ManuallySetFeatureID", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
