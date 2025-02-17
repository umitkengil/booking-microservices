using FluentValidation;

namespace Flight.Seats.Features.GetAvailableSeats.Queries.V1;

public class GetAvailableSeatsQueryValidator : AbstractValidator<GetAvailableSeatsQuery>
{
    public GetAvailableSeatsQueryValidator()
    {
        CascadeMode = CascadeMode.Stop;

        RuleFor(x => x.FlightId).NotNull().WithMessage("FlightId is required!");
    }
}
