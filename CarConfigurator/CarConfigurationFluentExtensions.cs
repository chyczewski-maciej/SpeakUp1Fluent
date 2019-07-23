using System.Collections.Generic;
using System.Linq;

namespace CarConfigurator
{
    public static class CarConfigurationFluentExtensions
    {
        public static CarConfiguration WithExteriorColor(this CarConfiguration carConfiguration, ExteriorColor exteriorColor)
        {
            return carConfiguration.With(exteriorColor);
        }

        public static CarConfiguration WithInteriorTrims(this CarConfiguration carConfiguration, InteriorTrims interiorTrims)
        {
            return carConfiguration.With(interiorTrims: interiorTrims);
        }

        public static CarConfiguration WithOptionalEquipment(this CarConfiguration carConfiguration, params OptionalEquipment[] optionalEquipment)
        {
            return carConfiguration.With(optionalEquipment: optionalEquipment);
        }

        public static CarConfiguration WithPackage(this CarConfiguration carConfiguration, OptionalEquipment[] package)
        {
            return carConfiguration.WithOptionalEquipment(package);
        }


        public static CarConfiguration WithUpholstery(this CarConfiguration carConfiguration, Upholstery upholstery)
        {
            return carConfiguration.With(upholstery: upholstery);
        }

        public static CarConfiguration WithAlloyWheels(this CarConfiguration carConfiguration, AlloyWheels alloyWheels)
        {
            return carConfiguration.With(alloyWheels: alloyWheels);
        }

        public static CarConfiguration WithoutOptionalEquipment(this CarConfiguration carConfiguration, OptionalEquipment optionalEquipment)
        {
            return new CarConfiguration(
                carConfiguration.ExteriorColor,
                carConfiguration.AlloyWheels,
                carConfiguration.Upholstery,
                carConfiguration.InteriorTrims,
                carConfiguration.OptionalEquipment.Where(o => o != optionalEquipment));
        }

        private static CarConfiguration With(
            this CarConfiguration carConfiguration,
            ExteriorColor? exteriorColor = null,
            AlloyWheels? alloyWheels = null,
            Upholstery? upholstery = null,
            InteriorTrims? interiorTrims = null,
            IEnumerable<OptionalEquipment> optionalEquipment = null)
        {
            return new CarConfiguration(
                exteriorColor ?? carConfiguration.ExteriorColor,
                alloyWheels ?? carConfiguration.AlloyWheels,
                upholstery ?? carConfiguration.Upholstery,
                interiorTrims ?? carConfiguration.InteriorTrims,
                carConfiguration.OptionalEquipment.Concat(optionalEquipment ?? Enumerable.Empty<OptionalEquipment>()).Distinct()
            );
        }
    }

    public static class CarConfigurationOptionalEquipmentFluentExtensions
    {
        public static CarConfiguration WithAutomaticAirConditioning(this CarConfiguration carConfiguration)
            => carConfiguration.WithOptionalEquipment(OptionalEquipment.Automatic_air_conditioning);

        public static CarConfiguration WithProfessionalNavigationSystems(this CarConfiguration carConfiguration)
            => carConfiguration.WithOptionalEquipment(OptionalEquipment.Navigation_system_professional);
    }
}
