﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContosoFlowers.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ContosoFlowers.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The bouquet &quot;{0} is invalid. Please try again..
        /// </summary>
        internal static string BouquetsDialog_InvalidOption {
            get {
                return ResourceManager.GetString("BouquetsDialog_InvalidOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select a bouquet for &quot;{0}&quot; category:.
        /// </summary>
        internal static string BouquetsDialog_Prompt {
            get {
                return ResourceManager.GetString("BouquetsDialog_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select.
        /// </summary>
        internal static string BouquetsDialog_Select {
            get {
                return ResourceManager.GetString("BouquetsDialog_Select", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The category &quot;{0} is invalid. Please try again..
        /// </summary>
        internal static string FlowerCategoriesDialog_InvalidOption {
            get {
                return ResourceManager.GetString("FlowerCategoriesDialog_InvalidOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select a category:.
        /// </summary>
        internal static string FlowerCategoriesDialog_Prompt {
            get {
                return ResourceManager.GetString("FlowerCategoriesDialog_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View bouquets.
        /// </summary>
        internal static string FlowerCategoriesDialog_Select {
            get {
                return ResourceManager.GetString("FlowerCategoriesDialog_Select", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What&apos;s the {&amp;}?.
        /// </summary>
        internal static string Order_RecipientFirstName_Prompt {
            get {
                return ResourceManager.GetString("Order_RecipientFirstName_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What&apos;s your billing address? Include apartment # if needed..
        /// </summary>
        internal static string RootDialog_BillingAddress_Prompt {
            get {
                return ResourceManager.GetString("RootDialog_BillingAddress_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select your billing address.
        /// </summary>
        internal static string RootDialog_BillingAddress_SelectSaved {
            get {
                return ResourceManager.GetString("RootDialog_BillingAddress_SelectSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Would you like to save this address?.
        /// </summary>
        internal static string RootDialog_BillingAddress_ShouldSave {
            get {
                return ResourceManager.GetString("RootDialog_BillingAddress_ShouldSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have selected: {0}.
        /// </summary>
        internal static string RootDialog_Bouquet_Selected {
            get {
                return ResourceManager.GetString("RootDialog_Bouquet_Selected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Changed my mind.
        /// </summary>
        internal static string RootDialog_Checkout_Cancel {
            get {
                return ResourceManager.GetString("RootDialog_Checkout_Cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add credit card.
        /// </summary>
        internal static string RootDialog_Checkout_Continue {
            get {
                return ResourceManager.GetString("RootDialog_Checkout_Continue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The order with ID &apos;{0}&apos; does not exists or is not confirmed. Please try to checkout again..
        /// </summary>
        internal static string RootDialog_Checkout_Error {
            get {
                return ResourceManager.GetString("RootDialog_Checkout_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The final price is {0} (including delivery). Pay securely using our payment provider..
        /// </summary>
        internal static string RootDialog_Checkout_Prompt {
            get {
                return ResourceManager.GetString("RootDialog_Checkout_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}, please enter the delivery address for these flowers. Include apartment # if needed..
        /// </summary>
        internal static string RootDialog_DeliveryAddress_Prompt {
            get {
                return ResourceManager.GetString("RootDialog_DeliveryAddress_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When would you like these delivered?.
        /// </summary>
        internal static string RootDialog_DeliveryDate_Prompt {
            get {
                return ResourceManager.GetString("RootDialog_DeliveryDate_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Great choice &quot;{0}&quot;! Delivery on {1}.
        /// </summary>
        internal static string RootDialog_DeliveryDate_Selected {
            get {
                return ResourceManager.GetString("RootDialog_DeliveryDate_Selected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keep going.
        /// </summary>
        internal static string RootDialog_Menu_Cancel {
            get {
                return ResourceManager.GetString("RootDialog_Menu_Cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What are you looking to do?.
        /// </summary>
        internal static string RootDialog_Menu_Prompt {
            get {
                return ResourceManager.GetString("RootDialog_Menu_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start over.
        /// </summary>
        internal static string RootDialog_Menu_StartOver {
            get {
                return ResourceManager.GetString("RootDialog_Menu_StartOver", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have canceled the operation. What would you like to do next?.
        /// </summary>
        internal static string RootDialog_Order_Cancelation {
            get {
                return ResourceManager.GetString("RootDialog_Order_Cancelation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Oops! Something went wrong :(. Technical Details: {0}.
        /// </summary>
        internal static string RootDialog_Order_Error {
            get {
                return ResourceManager.GetString("RootDialog_Order_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Order ID.
        /// </summary>
        internal static string RootDialog_Receipt_OrderID {
            get {
                return ResourceManager.GetString("RootDialog_Receipt_OrderID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Payment Method.
        /// </summary>
        internal static string RootDialog_Receipt_PaymentMethod {
            get {
                return ResourceManager.GetString("RootDialog_Receipt_PaymentMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to **Your order {0} has been processed!**
        ///The **{1}** will be sent to **{2} {3}** with the following note:
        ///		&quot;{4}&quot;.
        ///Thank you for using Contoso Flowers.
        ///Here is your receipt:.
        /// </summary>
        internal static string RootDialog_Receipt_Text {
            get {
                return ResourceManager.GetString("RootDialog_Receipt_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contoso Flowers Receipt.
        /// </summary>
        internal static string RootDialog_Receipt_Title {
            get {
                return ResourceManager.GetString("RootDialog_Receipt_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Support will contact you shortly. Have a nice day :).
        /// </summary>
        internal static string RootDialog_Support_Message {
            get {
                return ResourceManager.GetString("RootDialog_Support_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Oops! Something went wrong after too many invalid attemps. Maybe you can start over again..
        /// </summary>
        internal static string RootDialog_TooManyAttempts {
            get {
                return ResourceManager.GetString("RootDialog_TooManyAttempts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 2. Brach Information.
        /// </summary>
        internal static string RootDialog_Welcome_Branch_Info {
            get {
                return ResourceManager.GetString("RootDialog_Welcome_Branch_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to That is not a valid option. Please try again..
        /// </summary>
        internal static string RootDialog_Welcome_Error {
            get {
                return ResourceManager.GetString("RootDialog_Welcome_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 3. Estimate your derlivery price.
        /// </summary>
        internal static string RootDialog_Welcome_Estimate_Price {
            get {
                return ResourceManager.GetString("RootDialog_Welcome_Estimate_Price", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome to DHL ChatBot Service. You can now use our services via bot..
        /// </summary>
        internal static string RootDialog_Welcome_Message {
            get {
                return ResourceManager.GetString("RootDialog_Welcome_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sample Menu.
        /// </summary>
        internal static string RootDialog_Welcome_Orders {
            get {
                return ResourceManager.GetString("RootDialog_Welcome_Orders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What kind of service you are looking for!.
        /// </summary>
        internal static string RootDialog_Welcome_Subtitle {
            get {
                return ResourceManager.GetString("RootDialog_Welcome_Subtitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Talk to support.
        /// </summary>
        internal static string RootDialog_Welcome_Support {
            get {
                return ResourceManager.GetString("RootDialog_Welcome_Support", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome to DHL ChatBot Service.
        /// </summary>
        internal static string RootDialog_Welcome_Title {
            get {
                return ResourceManager.GetString("RootDialog_Welcome_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1. Tracking Item.
        /// </summary>
        internal static string RootDialog_Welcome_Tracking_Item {
            get {
                return ResourceManager.GetString("RootDialog_Welcome_Tracking_Item", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thanks! Your {0} address was updated to {1}..
        /// </summary>
        internal static string SettingsDialog_Address_Entered {
            get {
                return ResourceManager.GetString("SettingsDialog_Address_Entered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What&apos;s your billing address? Include apartment # if needed..
        /// </summary>
        internal static string SettingsDialog_BillingAddress_Prompt {
            get {
                return ResourceManager.GetString("SettingsDialog_BillingAddress_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 3. Edit addresses.
        /// </summary>
        internal static string SettingsDialog_Edit_BillingAddress {
            get {
                return ResourceManager.GetString("SettingsDialog_Edit_BillingAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 1. Edit email.
        /// </summary>
        internal static string SettingsDialog_Edit_Email {
            get {
                return ResourceManager.GetString("SettingsDialog_Edit_Email", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 2. Edit phone number.
        /// </summary>
        internal static string SettingsDialog_Edit_PhoneNumber {
            get {
                return ResourceManager.GetString("SettingsDialog_Edit_PhoneNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thanks! Your email was updated to {0}..
        /// </summary>
        internal static string SettingsDialog_Email_Entered {
            get {
                return ResourceManager.GetString("SettingsDialog_Email_Entered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thanks! Your phone was updated to {0}..
        /// </summary>
        internal static string SettingsDialog_PhoneNumber_Entered {
            get {
                return ResourceManager.GetString("SettingsDialog_PhoneNumber_Entered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type your {0} or use (B)ack to return to the menu..
        /// </summary>
        internal static string SettingsDialog_PrompString {
            get {
                return ResourceManager.GetString("SettingsDialog_PrompString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is your current {0}: {1}.
        ///Type a new {0} if you need to update, or use (B)ack to return to the menu..
        /// </summary>
        internal static string SettingsDialog_PrompString_CurrentValue {
            get {
                return ResourceManager.GetString("SettingsDialog_PrompString_CurrentValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something doesn&apos;t seem quite right with that {0}. Please try again..
        /// </summary>
        internal static string SettingsDialog_PrompString_Retry {
            get {
                return ResourceManager.GetString("SettingsDialog_PrompString_Retry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Want to make changes to your personal info or addresses? You&apos;re in the right place..
        /// </summary>
        internal static string SettingsDialog_Prompt {
            get {
                return ResourceManager.GetString("SettingsDialog_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Which address do you wish to update?.
        /// </summary>
        internal static string SettingsDialog_PromptAddress_Ask {
            get {
                return ResourceManager.GetString("SettingsDialog_PromptAddress_Ask", resourceCulture);
            }
        }
    }
}
