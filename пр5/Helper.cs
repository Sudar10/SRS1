using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using пр5.models;

namespace пр5
{
    public class Helper
    {
        private static models.NapitkiEntities s_firstDBEntity;

        public static models.NapitkiEntities getContext()
        {
            if (s_firstDBEntity == null)
            {
                s_firstDBEntity = new NapitkiEntities();
            }
            return s_firstDBEntity;
        }

        public void CreateUsers(models.Users users)
        {
            getContext().Users.Add(users);
            getContext().SaveChanges();
        }

        public void UpdateUsers(models.Users users)
        {
            s_firstDBEntity.Entry(users).State = EntityState.Modified;
            s_firstDBEntity.SaveChanges();
        }

        public void RemoveUsers(int idUsers)
        {
            var users = s_firstDBEntity.Users.Find(idUsers);
            s_firstDBEntity.Users.Remove(users);
            s_firstDBEntity.SaveChanges();
        }

        public void FiltrUsers()
        {
            var users = s_firstDBEntity.Users.Where(x => x.Login.StartsWith("М") || x.Login.StartsWith("А"));
        }
        public void SortUsers()
        {
            var users = s_firstDBEntity.Users.OrderBy(x => x.Login);
        }
    }
}
