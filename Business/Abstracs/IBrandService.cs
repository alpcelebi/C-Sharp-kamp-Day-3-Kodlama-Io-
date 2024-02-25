using Business.Dtos.Request;
using Business.Dtos.Responses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Business.Dtos.Responses.CreatedBrandResponse;

namespace Business.Abstracs
{
    public interface IBrandService
    {

        CreatedBrandResponse Add(CreatedBrandRequest createdBrandRequest);
        List<GetAllBrandResponse> GetAll();
    }
}
