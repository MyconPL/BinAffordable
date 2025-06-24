using System.ComponentModel.DataAnnotations;

namespace Domain.Enums;

public enum ContainerSize
{
    [Display(Name = "5")]
    Size5 = 5,

    [Display(Name = "10")]
    Size10 = 10,

    [Display(Name = "14")]
    Size14 = 14,

    [Display(Name = "16")]
    Size16 = 16,

    [Display(Name = "18")]
    Size18 = 18,

    [Display(Name = "21")]
    Size21 = 21
}
