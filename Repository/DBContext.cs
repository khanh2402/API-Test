using API.CSDL.BaoChi.Models;
using Dapper;
using Newtonsoft.Json;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Reflection.PortableExecutable;
using XAct;
using XAct.Messages;

namespace API.CSDL.BaoChi.Repository
{
    public class DBContext : IDisposable
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public DBContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ResponseList GetList(string store, List<SqlParameter>? param = null)
        {
            string myConn = _connectionString;
            using (var conn = new SqlConnection(myConn))
            {
                conn.Open();
                var Response = new ResponseList();
                Response.storeName = store;
                Response.store_type = 2;
                try
                {
                    // 1.  Tạo command với tên stored procedure
                    SqlCommand cmd = new SqlCommand(store, conn);
                    // 2. Cập nhật loại stored procedure
                    cmd.CommandType = CommandType.StoredProcedure;
                    // 3. Thêm input tới stored procedure
                    if (param != null)
                    {
                        foreach (SqlParameter para in param)
                        {
                            cmd.Parameters.Add(para);
                        }
                    }

                    // Thực thi
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Kiểm tra có kết quả trả về
                        if (reader.HasRows)
                        {
                            // Đọc từng dòng tập kết quả
                            var dataTable = new DataTable();
                            dataTable.Load(reader);
                            string JSONString = JsonConvert.SerializeObject(dataTable);
                            Response.data = JSONString;
                            Response.message = "Thành công";
                        }
                        else
                        {
                            Response.message = "Không tìm thấy dữ liệu";
                        }
                    }
                    Response.success = true;
                }
                catch (Exception ex)
                {
                    Response.data = null;
                    Response.message = ex.Message;
                    Response.success = false;
                }
                finally
                {
                   // Response.param = param;
                    conn.Close();
                }
                return Response;
            }
        }
        private string GetNow()
        {
            return DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
        }
    }
}
