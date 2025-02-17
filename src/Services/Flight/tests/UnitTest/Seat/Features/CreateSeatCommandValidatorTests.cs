﻿using Flight.Seats.Features.CreateSeat;
using Flight.Seats.Features.CreateSeat.Commands.V1;
using FluentAssertions;
using FluentValidation.TestHelper;
using Unit.Test.Common;
using Unit.Test.Fakes;
using Xunit;

namespace Unit.Test.Seat.Features;

[Collection(nameof(UnitTestFixture))]
public class CreateSeatCommandValidatorTests
{
    [Fact]
    public void is_valid_should_be_false_when_have_invalid_parameter()
    {
        // Arrange
        var command = new FakeValidateCreateSeatCommand().Generate();
        var validator = new CreateSeatCommandValidator();

        // Act
        var result = validator.TestValidate(command);

        // Assert
        result.IsValid.Should().BeFalse();
        result.ShouldHaveValidationErrorFor(x => x.SeatNumber);
        result.ShouldHaveValidationErrorFor(x => x.FlightId);
        result.ShouldHaveValidationErrorFor(x => x.Class);
    }
}
