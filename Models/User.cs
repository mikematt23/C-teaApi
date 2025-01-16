using System;
using System.Collections.Generic;

namespace realTeaShop.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? Score { get; set; }
}
