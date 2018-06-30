using SeriesUp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SeriesUp.Services
{
    public interface ISerieService
    {
        Task<SerieResponse> GetSeriesAsync();
    }
}
