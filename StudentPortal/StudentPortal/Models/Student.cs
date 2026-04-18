using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Models;

public partial class Student
{
    public int StudentId { get; set; }

    [Required(ErrorMessage = "Full name is required")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name can contain only letters")]
    public string FullName { get; set; } = null!;

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Enter a valid email address")]
    [StringLength(100)]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Phone number is required")]
    [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Enter a valid 10 digit phone number")]
    public string? Phone { get; set; }

    public string? Status { get; set; }

    public DateOnly JoinDate { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<TblLog> TblLogs { get; set; } = new List<TblLog>();
}
