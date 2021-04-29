﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedSocial.Models;

namespace RedSocial.Services.Interfaces
{
    public interface IPublicacionService
    {
        Task<IEnumerable<PublicacionModel>> GetPublicacionAsync();

        Task<IEnumerable<PublicacionModel>> GetPublicacionLikeCountAsync(int id);

        Task<PublicacionModel> PostPublicacionAsync(PublicacionModel model);

        Task<IEnumerable<PublicacionModel>> DeletePublicacionAsync(int id);

        Task<LikeModel> DarLikeAsync(LikeModel model);
       
    }
}