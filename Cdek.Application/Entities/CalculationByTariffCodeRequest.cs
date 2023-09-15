using JetBrains.Annotations;

namespace Cdek.Application.Entities;

/// <summary>
/// Class CalculationByTariffCodeRequest.
/// </summary>
public class CalculationByTariffCodeRequest
{
    /// <summary>
    /// Gets or sets the date.
    /// </summary>
    /// <value>The date.</value>
    [CanBeNull]
    public string date { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    /// <value>The type.</value>
    [CanBeNull]
    public int type { get; set; } = new();

    /// <summary>
    /// Gets or sets the additional order types.
    /// </summary>
    /// <value>The additional order types.</value>
    [CanBeNull]
    public IEnumerable<int> additional_order_types { get; set; } = new List<int>();

    /// <summary>
    /// Gets or sets the currency.
    /// </summary>
    /// <value>The currency.</value>
    [CanBeNull]
    public int currency { get; set; } = new();

    /// <summary>
    /// Gets or sets the tariff code.
    /// </summary>
    /// <value>The tariff code.</value>
    public int tariff_code { get; set; } = new();

    /// <summary>
    /// Gets or sets from location.
    /// </summary>
    /// <value>From location.</value>
    public Location from_location { get; set; } = new();

    /// <summary>
    /// Gets or sets to location.
    /// </summary>
    /// <value>To location.</value>
    public Location to_location { get; set; } = new();

    /// <summary>
    /// Gets or sets the services.
    /// </summary>
    /// <value>The services.</value>
    public List<Service> services { get; set; } = new();

    /// <summary>
    /// Gets or sets the packages.
    /// </summary>
    /// <value>The packages.</value>
    public List<Package> packages { get; set; } = new();
}

/// <summary>
/// Class Location.
/// </summary>
public class Location
{
    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    public int code { get; set; } = new();

    /// <summary>
    /// Gets or sets the postal code.
    /// </summary>
    /// <value>The postal code.</value>
    public string postal_code { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the country code.
    /// </summary>
    /// <value>The country code.</value>
    public string country_code { get; set; } = "RU";

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    /// <value>The city.</value>
    public string city { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the address.
    /// </summary>
    /// <value>The address.</value>
    public string address { get; set; } = string.Empty;
}

/// <summary>
/// Class Service.
/// </summary>
public class Service
{
    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    public string code { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the parameter.
    /// </summary>
    /// <value>The parameter.</value>
    public string parameter { get; set; } = string.Empty;
}

/// <summary>
/// Class Package.
/// </summary>
public class Package
{
    /// <summary>
    /// Gets or sets the weight.
    /// </summary>
    /// <value>The weight.</value>
    public int weight { get; set; } = new();

    /// <summary>
    /// Gets or sets the length.
    /// </summary>
    /// <value>The length.</value>
    public int length { get; set; } = new();

    /// <summary>
    /// Gets or sets the width.
    /// </summary>
    /// <value>The width.</value>
    public int width { get; set; } = new();

    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    /// <value>The height.</value>
    public int height { get; set; } = new();
}