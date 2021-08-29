﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ExpenseTracker.Shared.Models;
using System.Threading.Tasks;

namespace ExpenseTracker.Components
{
    public partial class LoginForm : ComponentBase 
    {

        [Inject]
        public HttpClient HttpClient { get; set; }

        private LoginRequest _model = new LoginRequest();

        private async Task LoginUserAsync()
        {
            throw new NotImplementedException();
        }
    }
}
