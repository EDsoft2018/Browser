using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSoft.Models
{
    /// <summary>
    /// 人员信息
    /// </summary>
  public  class T_TYXX
    {
        [Key]
        public Guid guid { get; set; } = Guid.NewGuid();
        public DateTime timestrap { get; set; } = DateTime.Now;

        /// <summary>
        /// 人员姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string SFZH { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string DZ { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string LXDH { get; set; }
        /// <summary>
        /// 银行卡号
        /// </summary>
        public string YHKH { get; set; }
        /// <summary>
        /// 开户行
        /// </summary>
        public string KHH { get; set; }
        /// <summary>
        /// 被授权时间
        /// </summary>
        public  string BSQSJ { get; set; }

    }
}
