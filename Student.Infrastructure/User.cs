using System;
using System.Collections.Generic;

namespace Student.Infrastructure;

public partial class User
{
    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Role { get; set; }
}
