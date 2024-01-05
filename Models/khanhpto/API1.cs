namespace API.ILIS.Models.khanhpto
{


    public class parentScope2
    {
        public string scopeId { get; set; }
        public string scopeName { get; set; }
        public string scopeCode { get; set; }
        public int scopeType { get; set; }
        public string parentScopeId { get; set; }
        public string parentScope { get; set; }
        public int scopeLevel { get; set; }
        public int customerId { get; set; }
        public string maTinh { get; set; }
        public string maHuyen { get; set; }
        public string maXa { get; set; }
        public string status { get; set; }
        public Boolean isSystem { get; set; }
        public string note { get; set; }

    }
    public class parentScope1
    {
        public string scopeId { get; set; }
        public string scopeName { get; set; }
        public string scopeCode { get; set; }
        public string scopeType { get; set; }
        public string parentScopeId { get; set; }
        public parentScope2 parentScope2 { get; set; }
        public int scopeLevel { get; set; }
        public int customerId { get; set; }
        public string maTinh { get; set; }
        public string maHuyen { get; set; }
        public string maXa { get; set; }
        public string status { get; set; }
        public Boolean isSystem { get; set; }
        public string note { get; set; }
    }
    public class API1
    {
        public string scopeId { get; set; }
        public string scopeName { get; set; }
        public string scopeCode { get; set; }
        public string scopeType { get; set; }
        public string parentScopeId { get; set; }
        public parentScope1 parentScope1 { get; set; }
        public int scopeLevel { get; set; }
        public int customerId { get; set; }
        public string maTinh { get; set; }
        public string maHuyen { get; set; }
        public string maXa { get; set; }
        public string status { get; set; }
        public Boolean isSystem { get; set; }
        public string note { get; set; }
    }
}
