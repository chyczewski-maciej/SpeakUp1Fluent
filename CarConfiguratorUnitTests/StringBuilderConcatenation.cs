using CarConfigurator;
using FluentAssertions;
using Xunit;
using static CarConfiguratorUnitTests.BddExtensions;

namespace CarConfiguratorUnitTests
{
    public class StringBuilderConcatenation
    {
        [Fact]
        public void Car_configuration_remains_unchanged_when_exterior_color_is_changed()
        {
            Given(A_car_configuration)
                .That(Has_alpine_white_exterior_color) // Assertion about the give
                .When(A_new_configuration_with_black_sapphire_metallic_color_is_created)
                .Then(Old_configuration_exterior_color_remains_alpine_white)
                .And(New_configuration_exterior_color_is_black_sapphire_metallic);
        }

        private static (CarConfiguration oldConfiguration, CarConfiguration newConfiguration)
            A_new_configuration_with_black_sapphire_metallic_color_is_created(CarConfiguration carConfiguration)
        {
            return (carConfiguration, carConfiguration.WithExteriorColor(ExteriorColor.Black_sapphire_metallic));
        }

        // ReSharper disable once InconsistentNaming
        private static CarConfiguration A_car_configuration() =>
             new CarConfiguration(
                ExteriorColor.Alpine_white,
                AlloyWheels.Bi_color_jet_black_18_inch,
                Upholstery.Anthracite_hexagon_alcantara,
                InteriorTrims.Aluminium_hexagon_with_black_high_gloss_finish,
                OptionalEquipment.Automatic_air_conditioning);

        private void Has_alpine_white_exterior_color(CarConfiguration configuration)
        {
            configuration.ExteriorColor.Should().Be(ExteriorColor.Alpine_white);
        }

        private void Old_configuration_exterior_color_remains_alpine_white((CarConfiguration oldConfiguration, CarConfiguration newConfiguration) configurations)
        {
            configurations.oldConfiguration.ExteriorColor.Should().Be(ExteriorColor.Alpine_white);
        }

        private void New_configuration_exterior_color_is_black_sapphire_metallic((CarConfiguration oldConfiguration, CarConfiguration newConfiguration) configurations)
        {
            configurations.newConfiguration.ExteriorColor.Should().Be(ExteriorColor.Black_sapphire_metallic);
        }
    }
}
