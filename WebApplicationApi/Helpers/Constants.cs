namespace WebApplicationApi.Helpers
{
    public class Constants
    {
        public enum StatusOfIndices
        {
            New = 0,
            Edit = 1,
            Public = 2,
        }
        public enum LevelOfDepartment
        {
            Tinh = 0,
            SoHuyenTp = 1,
            PhongXaPhuong = 2,
        }
        public enum ResponseStatus
        {
            Susscess = 1,
            Fail = 2,
            Existed = 3,
            NonExisted = 4,
            NotFound = 5,
            NotAllowAccessData = 6,
        }
        public enum LogAction
        {
            Add = 1,
            Edit = 2,
            Delete = 3,
            Login = 4,
            LogOut = 5,
            ChangePassWord = 6,
            Lock = 7,
            Unlock = 8,
            Publish = 9,
            Retrieve = 10,
            Send = 11,
            Confirm = 12,
            Review = 13,
            Resend = 14,
        }
    }
}
