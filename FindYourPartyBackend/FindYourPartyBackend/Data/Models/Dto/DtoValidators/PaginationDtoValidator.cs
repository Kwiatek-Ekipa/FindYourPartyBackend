using FindYourPartyBackend.Data.Models.Dto.DtoPagination;
using FluentValidation;

namespace FindYourPartyBackend.Data.Models.Dto.DtoValidators
{
    public class PaginationDtoValidator : AbstractValidator<PaginationDto>
    {
        private int[] allowedPageSize = new[] {-1, 10, 20, 30};
        public PaginationDtoValidator()
        {
            RuleFor(r => r.PageIndex).GreaterThanOrEqualTo(1);
            RuleFor(r => r.PageSize).Custom((value, context) =>
            {
                if(!allowedPageSize.Contains(value))
                {
                    context.AddFailure("PageSize", $"PageSize must be in [{string.Join(",", allowedPageSize)}]");
                }
            });
        }
    }
}
