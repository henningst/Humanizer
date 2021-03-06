﻿using Humanizer.Localisation;
using Xunit.Extensions;

namespace Humanizer.Tests.Localisation.de
{
    public class DateHumanizeTests : AmbientCulture
    {
        public DateHumanizeTests() : base("de-DE") {}

        [Theory]
        [InlineData(-10, "vor 10 Tagen")]
        [InlineData(-3, "vor 3 Tagen")]
        [InlineData(-2, "vor 2 Tagen")]
        [InlineData(-1, "gestern")]
        public void DaysAgo(int days, string expected)
        {
            DateHumanize.Verify(expected, days, TimeUnit.Day, Tense.Past);
        }

        [Theory]
        [InlineData(2, "in 2 Tagen")]
        [InlineData(1, "morgen")]
        public void DaysFromNow(int days, string expected)
        {
            DateHumanize.Verify(expected, days, TimeUnit.Day, Tense.Future);
        }

        [Theory]
        [InlineData(-10, "vor 10 Stunden")]
        [InlineData(-3, "vor 3 Stunden")]
        [InlineData(-2, "vor 2 Stunden")]
        [InlineData(-1, "vor einer Stunde")]
        public void HoursAgo(int hours, string expected)
        {
            DateHumanize.Verify(expected, hours, TimeUnit.Hour, Tense.Past);
        }

        [Theory]
        [InlineData(2, "in 2 Stunden")]
        [InlineData(1, "in einer Stunde")]
        public void HoursFromNow(int hours, string expected)
        {
            DateHumanize.Verify(expected, hours, TimeUnit.Hour, Tense.Future);
        }

        [Theory]
        [InlineData(-10, "vor 10 Minuten")]
        [InlineData(-3, "vor 3 Minuten")]
        [InlineData(-2, "vor 2 Minuten")]
        [InlineData(-1, "vor einer Minute")]
        public void MinutesAgo(int minutes, string expected)
        {
            DateHumanize.Verify(expected, minutes, TimeUnit.Minute, Tense.Past);
        }

        [Theory]
        [InlineData(2, "in 2 Minuten")]
        [InlineData(1, "in einer Minute")]
        public void MinutesFromNow(int minutes, string expected)
        {
            DateHumanize.Verify(expected, minutes, TimeUnit.Minute, Tense.Future);
        }

        [Theory]
        [InlineData(-10, "vor 10 Monaten")]
        [InlineData(-3, "vor 3 Monaten")]
        [InlineData(-2, "vor 2 Monaten")]
        [InlineData(-1, "vor einem Monat")]
        public void MonthsAgo(int months, string expected)
        {
            DateHumanize.Verify(expected, months, TimeUnit.Month, Tense.Past);
        }

        [Theory]
        [InlineData(2, "in 2 Monaten")]
        [InlineData(1, "in einem Monat")]
        public void MonthsFromNow(int months, string expected)
        {
            DateHumanize.Verify(expected, months, TimeUnit.Month, Tense.Future);
        }

        [Theory]
        [InlineData(-10, "vor 10 Sekunden")]
        [InlineData(-3, "vor 3 Sekunden")]
        [InlineData(-2, "vor 2 Sekunden")]
        [InlineData(-1, "vor einer Sekunde")]
        public void SecondsAgo(int seconds, string expected)
        {
            DateHumanize.Verify(expected, seconds, TimeUnit.Second, Tense.Past);
        }

        [Theory]
        [InlineData(2, "in 2 Sekunden")]
        [InlineData(1, "in einer Sekunde")]
        public void SecondsFromNow(int seconds, string expected)
        {
            DateHumanize.Verify(expected, seconds, TimeUnit.Second, Tense.Future);
        }

        [Theory]
        [InlineData(-10, "vor 10 Jahren")]
        [InlineData(-3, "vor 3 Jahren")]
        [InlineData(-2, "vor 2 Jahren")]
        [InlineData(-1, "vor einem Jahr")]
        public void YearsAgo(int years, string expected)
        {
            DateHumanize.Verify(expected, years, TimeUnit.Year, Tense.Past);
        }

        [Theory]
        [InlineData(2, "in 2 Jahren")]
        [InlineData(1, "in einem Jahr")]
        public void YearsFromNow(int years, string expected)
        {
            DateHumanize.Verify(expected, years, TimeUnit.Year, Tense.Future);
        }
    }
}
