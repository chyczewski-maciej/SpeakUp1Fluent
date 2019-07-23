namespace CarConfigurator
{
    public static class CarConfigurations
    {
        public static CarConfiguration StandardEdition { get; } =
            new CarConfiguration(
                ExteriorColor.Alpine_white,
                AlloyWheels.Double_spoke_style_17_inch,
                Upholstery.Anthracite_hexagon_alcantara,
                InteriorTrims.Brushed_aluminium_with_black_high_gloss_finish,
                OptionalEquipment.Bluetooth_hands_free,
                OptionalEquipment.DAB_digital_radio,
                OptionalEquipment.Sport_seats_front,
                OptionalEquipment.Sport_suspension,
                OptionalEquipment.Real_time_traffic_information
                );

        public static CarConfiguration Sport { get; } = StandardEdition
                                                        .WithUpholstery(Upholstery.Black_dakota_leather)
                                                        .WithAlloyWheels(AlloyWheels.Jet_black_18_inch)
                                                        .WithPackage(OptionalPackages.Media_package_professional)
                                                        .WithOptionalEquipment(OptionalEquipment.Sport_steering_wheel,
                                                                               OptionalEquipment.Rain_sensor);

        public static CarConfiguration MSport { get; } = Sport
                                                            .WithExteriorColor(ExteriorColor.Black_sapphire_metallic)
                                                            .WithUpholstery(Upholstery.Coral_red_with_black_dakota_leather)
                                                            .WithAlloyWheels(AlloyWheels.Double_spoke_style_17_inch_run_flat)
                                                            .WithInteriorTrims(InteriorTrims.High_gloss_black_with_pearl_chrome_finish)
                                                            .WithOptionalEquipment(OptionalEquipment.Chrome_line_exterior,
                                                                                   OptionalEquipment.Automatic_air_conditioning,
                                                                                   OptionalEquipment.Harman_Kardon_HiFi,
                                                                                   OptionalEquipment.Windscreen_with_grey_shade_band,
                                                                                   OptionalEquipment.Sport_suspension);

    }
}
