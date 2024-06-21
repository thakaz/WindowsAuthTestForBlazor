using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Windows認証テスト.Model
{
    [Table("users"),Comment("ログイン管理用")]
    public class User
    {
    [Column("user_id"), Comment("ユーザーID")]
        [Key]
        public string UserId { get; set; }
        /// <summary>
        /// 権限   0:一般ユーザ  1: 管理者の想定
        /// </summary>
        [Column("role"),Comment("権限コード")]
        public int Role { get; set; }
    }
}
