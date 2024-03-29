﻿using System.Threading.Tasks;

namespace Kinesia.Gestion.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}