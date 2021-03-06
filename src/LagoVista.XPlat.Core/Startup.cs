﻿using LagoVista.Client.Core.ViewModels.Auth;
using LagoVista.Client.Core.ViewModels.Orgs;
using LagoVista.Client.Core.ViewModels.Other;
using LagoVista.Client.Core.ViewModels.Users;
using LagoVista.XPlat.Core.Services;
using LagoVista.XPlat.Core.Views.Auth;
using LagoVista.XPlat.Core.Views.Orgs;
using LagoVista.XPlat.Core.Views.Other;
using LagoVista.XPlat.Core.Views.Users;

namespace LagoVista.XPlat.Core
{
    public static class Startup
    {

        public static void Init(Xamarin.Forms.Application app, ViewModelNavigation nav)
        {
            nav.Add<LoginViewModel, LoginView>();
            nav.Add<ChangePasswordViewModel, ChangePasswordView>();
            nav.Add<SendResetPasswordLinkViewModel, SendResetPasswordView>();
            nav.Add<ResetPasswordViewModel, ResetPasswordView>();
            nav.Add<InviteUserViewModel, InviteUserView>();

            nav.Add<RegisterUserViewModel, RegisterView>();
            nav.Add<VerifyUserViewModel, VerifyUserView>();
            nav.Add<OrgEditorViewModel, OrgEditorView>();
            nav.Add<UserOrgsViewModel, UserOrgsView>();
            nav.Add<AboutViewModel, AboutView>();
            nav.Add<AcceptInviteViewModel, AcceptInviteView>();
        }
    }
}
