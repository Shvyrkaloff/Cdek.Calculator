namespace Cdek.Application.Entities;

/// <summary>
/// Class CalculationByTariffCodeResponse.
/// </summary>
public class CalculationByTariffCodeResponse
{
    /// <summary>
    /// Gets or sets the delivery sum.
    /// </summary>
    /// <value>The delivery sum.</value>
    public double delivery_sum { get; set; }

    /// <summary>
    /// Gets or sets the period minimum.
    /// </summary>
    /// <value>The period minimum.</value>
    public int period_min { get; set; }

    /// <summary>
    /// Gets or sets the period maximum.
    /// </summary>
    /// <value>The period maximum.</value>
    public int period_max { get; set; }

    /// <summary>
    /// Gets or sets the calendar minimum.
    /// </summary>
    /// <value>The calendar minimum.</value>
    public int calendar_min { get; set; }

    /// <summary>
    /// Gets or sets the calendar maximum.
    /// </summary>
    /// <value>The calendar maximum.</value>
    public int calendar_max { get; set; }

    /// <summary>
    /// Gets or sets the services.
    /// </summary>
    /// <value>The services.</value>
    public List<Service> services { get; set; }

    /// <summary>
    /// Gets or sets the total sum.
    /// </summary>
    /// <value>The total sum.</value>
    public float total_sum { get; set; }

    /// <summary>
    /// Gets or sets the currency.
    /// </summary>
    /// <value>The currency.</value>
    public string currency { get; set; }

    /// <summary>
    /// Gets or sets the errors.
    /// </summary>
    /// <value>The errors.</value>
    public List<Error> errors { get; set; }
}

/// <summary>
/// Class Error.
/// </summary>
public class Error
{
    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    public string code { get; set; }

    /// <summary>
    /// Gets or sets the message.
    /// </summary>
    /// <value>The message.</value>
    public string message { get; set; }
}