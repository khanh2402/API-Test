using API.CSDL.BaoChi.Repository;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace API.CSDL.BaoChi.Models
{
    public class ResponseList
    {
        public bool success { get; set; }
        public string? message { get; set; }
        public string? storeName { get; set; }
        public int store_type { get; set; }
        public string? data { get; set; }
        public List<SqlParameter>? param { get; set; }
    }
}
