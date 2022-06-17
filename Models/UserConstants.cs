using System.Collections.Generic;

namespace WebApi.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() {Username = "zeynepakcelioglu@hotmail.com", Password="MyPass_Word" },
            new UserModel() {Username = "akceliogluzeynep@gmail.com", Password="MyPass_Word" },
        };
    }
}
