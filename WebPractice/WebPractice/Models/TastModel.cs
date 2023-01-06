using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace WebPractice.Models
{
    public class TastModel : Controller
    {
        public class TastText
        {
            [Display(Name= "名前")]
            [DataMember(Name="Name")]
            public string? Name { get; set; }
            [Display(Name="味")]
            [DataMember(Name="Tast")]
            public string? Tast { get; set; }
            [Display(Name="ノート")]
            [DataMember(Name="note")]
            public string? Note { get; set; }
            [Display(Name="点数")]
            [DataMember(Name="score")]
            public int Score { get; set; }
        }
    }
}
