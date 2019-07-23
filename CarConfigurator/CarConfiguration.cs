using System.Collections.Generic;
using System.Linq;

// ReSharper disable InconsistentNaming
namespace CarConfigurator
{
    public enum ExteriorColor
    {
        Alpine_white,
        Black_sapphire_metallic,
        Melbourne_red_metallic,
        Mineral_white_metallic,
        Mineral_grey_metallic,
        Estoril_blue_metallic,
        Sunset_orange_metallic
    }

    public enum AlloyWheels
    {
        Double_spoke_style_17_inch,
        Double_spoke_style_17_inch_run_flat,
        Y_spoke_style_17_inch,
        Double_spoke_style_18_inch,
        Jet_black_18_inch,
        Bi_color_jet_black_18_inch
    }

    public enum Upholstery
    {
        Anthracite_hexagon_alcantara,
        Coral_red_with_black_dakota_leather,
        Black_dakota_leather,
        Oyster_dakota_leather,
        Cognac_dakota_leather,
    }

    public enum InteriorTrims
    {
        Brushed_aluminium_with_black_high_gloss_finish,
        Brushed_aluminium_with_pearl_chrome_finish,
        High_gloss_black_with_pearl_chrome_finish,
        Fineline_stream_wood_with_pearl_chrome_finish,
        Aluminium_hexagon_with_estoril_blue_finish,
        Aluminium_hexagon_with_black_high_gloss_finish
    }

    // Flags could have been used here as well
    // Warning: Flags simplify things here but it could turn into a pain when you start saving them as numbers.
    public enum OptionalEquipment
    {
        None,
        Navigation_system_professional,
        Harman_Kardon_HiFi,
        Bluetooth_hands_free,
        Chrome_line_exterior,
        Windscreen_with_grey_shade_band,
        DAB_digital_radio,
        Real_time_traffic_information,
        Extended_interior_light_package,
        Extended_storage,
        Automatic_air_conditioning,
        Online_entertainment,
        Black_panel_display,
        Remote_services,
        Sport_seats_front,
        Sport_suspension,
        Rain_sensor,
        Sport_steering_wheel
    }

    // Turns out the base class doesn't really need to be fluent at all!
    // Immutability and fluent interfaces play well both together and alone!
    // Thanks to immutability we can be sure the object remains unchanged and is threadsafe.
    // https://configure.bmw.co.uk/en_GB/configure/F22/
    public class CarConfiguration
    {
        public ExteriorColor ExteriorColor { get; }
        public AlloyWheels AlloyWheels { get; }
        public Upholstery Upholstery { get; }
        public InteriorTrims InteriorTrims { get; }
        public IEnumerable<OptionalEquipment> OptionalEquipment { get; }


        public CarConfiguration(
            ExteriorColor exteriorColor,
            AlloyWheels alloyWheels,
            Upholstery upholstery,
            InteriorTrims interiorTrims,
            IEnumerable<OptionalEquipment> optionalEquipment)
        {
            ExteriorColor = exteriorColor;
            AlloyWheels = alloyWheels;
            Upholstery = upholstery;
            InteriorTrims = interiorTrims;
            OptionalEquipment = optionalEquipment;
        }

        // An overload tu support the params
        public CarConfiguration(
            ExteriorColor exteriorColor,
            AlloyWheels alloyWheels,
            Upholstery upholstery,
            InteriorTrims interiorTrims,
            params OptionalEquipment[] optionalEquipment)
                : this(exteriorColor, alloyWheels, upholstery, interiorTrims, optionalEquipment.AsEnumerable())
        {
        }
    }

    public static class OptionalPackages
    {
        public static OptionalEquipment[] Interior_comfort_package { get; } =
            {
                OptionalEquipment.Extended_interior_light_package,
                OptionalEquipment.Extended_storage,
                OptionalEquipment.Automatic_air_conditioning,
            };

        public static OptionalEquipment[] Media_package_professional { get; } =
            {
                OptionalEquipment.Online_entertainment,
                OptionalEquipment.Navigation_system_professional,
                OptionalEquipment.Black_panel_display,
                OptionalEquipment.Remote_services
            };
    }
}