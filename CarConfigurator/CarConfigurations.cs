using static CarConfigurator.AlloyWheels;
using static CarConfigurator.ExteriorColor;
using static CarConfigurator.InteriorTrims;
using static CarConfigurator.OptionalEquipment;
using static CarConfigurator.OptionalPackages;
using static CarConfigurator.Upholstery;

namespace CarConfigurator
{
    public static class CarConfigurations
    {
        public static CarConfiguration StandardEdition { get; } =
            new CarConfiguration(
                Alpine_white,
                Double_spoke_style_17_inch,
                Anthracite_hexagon_alcantara,
                Brushed_aluminium_with_black_high_gloss_finish,
                Bluetooth_hands_free,
                DAB_digital_radio,
                Sport_seats_front,
                Sport_suspension,
                Real_time_traffic_information
                );

        public static CarConfiguration Sport { get; } = StandardEdition
                                                        .WithAutomaticAirConditioning()
                                                        .WithUpholstery(Black_dakota_leather)
                                                        .WithAlloyWheels(Jet_black_18_inch)
                                                        .WithPackage(Media_package_professional)
                                                        .WithOptionalEquipment(Sport_steering_wheel,
                                                                               Rain_sensor);

        public static CarConfiguration MSport { get; } = Sport
                                                            .WithExteriorColor(Black_sapphire_metallic)
                                                            .WithUpholstery(Coral_red_with_black_dakota_leather)
                                                            .WithAlloyWheels(Double_spoke_style_17_inch_run_flat)
                                                            .WithInteriorTrims(High_gloss_black_with_pearl_chrome_finish)
                                                            .WithOptionalEquipment(Chrome_line_exterior,
                                                                                   Automatic_air_conditioning,
                                                                                   Harman_Kardon_HiFi,
                                                                                   Windscreen_with_grey_shade_band,
                                                                                   Sport_suspension);

    }
}
