using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo> _userInfo = new();

        static Repository()
        {
            _userInfo.Add(new UserInfo() {Id =1,Name="Kerem",Email="keremeyrbkn@gmail.com",Phone="05469615432",WillAttend=true});
            _userInfo.Add(new UserInfo() {Id =2,Name="Süleyman",Email="Süleyman@gmail.com",Phone="05469615432",WillAttend=false});
            _userInfo.Add(new UserInfo() {Id =3,Name="Hıdır",Email="Hıdır@gmail.com",Phone="05469615432",WillAttend=true});
        }
        public static List<UserInfo> Users{
            get{
                return  _userInfo;
            }
        }

        public static void CreateUser(UserInfo user)
        {    user.Id = Users.Count + 1;
            _userInfo.Add(user);
        }
        public static List<UserInfo> GetAll()
        {
            return _userInfo.ToList();
        }

        public static UserInfo? GetById(int id)
        {
            return _userInfo.FirstOrDefault(u => u.Id==id);
        }
    }
}