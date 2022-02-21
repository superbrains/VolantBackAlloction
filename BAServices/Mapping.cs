﻿using AutoMapper;
using BAServices.Models;
using System;
using System.Collections.Generic;
using System.Text;

using VolantBackAlloction.ViewModels.Tenant;

namespace BAServices
{

    public class MyProfiles : Profile
    {
        public MyProfiles()
        {

            CreateMap<TenantVM,Tenants >().ReverseMap();
          
        }
    }
}
