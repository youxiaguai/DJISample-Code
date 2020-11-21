using DJI.WindowsSDK;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace DJIWindowsSDKSample.DJISDKInitializing
{
    public sealed partial class ActivatingPage : Page
    {
        public ActivatingPage()
        {
            this.InitializeComponent();
            DJISDKManager.Instance.SDKRegistrationStateChanged += Instance_SDKRegistrationEvent;
        }

        private async void Instance_SDKRegistrationEvent(SDKRegistrationState state, SDKError resultCode)
        {
           //await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            //{
               //activateStateTextBlock.Text = state == SDKRegistrationState.Succeeded ? "Activated." : "Not Activated.";
               //activationInformation.Text = resultCode == SDKError.NO_ERROR ? "Register success" : resultCode.ToString();
           // });
        }

        private async void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string userName = this.userName.Text;
            string passWord = this.passWord.Password;
            if (userName == "123" && passWord == "123")
           
            {
                var messageDialog = new MessageDialog("登陆成功");
                await messageDialog.ShowAsync();
                    string ActivatingCodeTextBox = "c713bd70d8f19f710cc97ce3";
                    DJISDKManager.Instance.RegisterApp(ActivatingCodeTextBox);
                    activationInformation.Text = "正在登陆中...";
                }
            else
            {
                var messageDialog = new MessageDialog("用户名或密码错误，请重新登录");
                await messageDialog.ShowAsync();
                this.userName.Text = "";
                this.passWord.Password = "";
            }
            
        }

    }
}
