using System.Diagnostics.CodeAnalysis;
namespace FreshdeskApi.Client.Tickets.Models
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public enum TicketSeverity
    {
        Normal,
        Minor,
        Immediate,
        Critical
    }
}
