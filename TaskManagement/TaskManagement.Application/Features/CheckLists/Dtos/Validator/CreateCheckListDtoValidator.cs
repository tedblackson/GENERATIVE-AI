using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Application.Features.CheckLists.Dtos.Validator
{
    public class CreateCheckListDtoValidator : AbstractValidator<CreateCheckListDto>
    {
        public CreateCheckListDtoValidator()
        {
            RuleFor(dto => dto.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(50).WithMessage("Title must not exceed 50 characters.");

            RuleFor(dto => dto.Description)
                .MaximumLength(500).WithMessage("Description must not exceed 500 characters.");
        }
    }
}
