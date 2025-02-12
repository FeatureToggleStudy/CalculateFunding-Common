﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CalculateFunding.Common.ApiClient.Policies.Models
{
    /// <summary>
    /// Valid list of organisation group types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrganisationGroupTypeIdentifier
    {
        /// <summary>
        /// UKPRN
        /// </summary>
        [EnumMember(Value = "UKPRN")]
        UKPRN,

        /// <summary>
        /// LACode
        /// </summary>
        [EnumMember(Value = "LACode")]
        LACode,

        /// <summary>
        /// UPIN
        /// </summary>
        [EnumMember(Value = "UPIN")]
        UPIN,

        /// <summary>
        /// URN
        /// </summary>
        [EnumMember(Value = "URN")]
        URN,

        /// <summary>
        /// UID
        /// </summary>
        [EnumMember(Value = "UID")]
        UID,

        /// <summary>
        /// CompaniesHouseNumber
        /// </summary>
        [EnumMember(Value = "CompaniesHouseNumber")]
        CompaniesHouseNumber,

        /// <summary>
        /// GroupID
        /// </summary>
        [EnumMember(Value = "GroupID")]
        GroupId,

        /// <summary>
        /// RSCRegionCode
        /// </summary>
        [EnumMember(Value = "RSCRegionCode")]
        RscRegionCode,

        /// <summary>
        /// GovernmentOfficeRegionCode
        /// </summary>
        [EnumMember(Value = "GovernmentOfficeRegionCode")]
        GovernmentOfficeRegionCode,

        /// <summary>
        /// LocalGovernmentGroupTypeCode
        /// </summary>
        [EnumMember(Value = "LocalGovernmentGroupTypeCode")]
        LocalGovernmentGroupTypeCode,

        /// <summary>
        /// DistrictCode
        /// </summary>
        [EnumMember(Value = "DistrictCode")]
        DistrictCode,

        /// <summary>
        /// WardCode
        /// </summary>
        [EnumMember(Value = "WardCode")]
        WardCode,

        /// <summary>
        /// CensusWardCode
        /// </summary>
        [EnumMember(Value = "CensusWardCode")]
        CensusWardCode,

        /// <summary>
        /// MiddleSuperOutputAreaCode
        /// </summary>
        [EnumMember(Value = "MiddleSuperOutputAreaCode")]
        MiddleSuperOutputAreaCode,

        /// <summary>
        /// LowerSuperOutputAreaCode
        /// </summary>
        [EnumMember(Value = "LowerSuperOutputAreaCode")]
        LowerSuperOutputAreaCode,

        /// <summary>
        /// ParliamentaryConstituencyCode
        /// </summary>
        [EnumMember(Value = "ParliamentaryConstituencyCode")]
        ParliamentaryConstituencyCode,

        /// <summary>
        /// DfeNumber
        /// </summary>
        [EnumMember(Value = "DfeNumber")]
        DfeEstablishmentNumber,

        /// <summary>
        /// AcademyTrustCode
        /// </summary>
        [EnumMember(Value = "AcademyTrustCode")]
        AcademyTrustCode,

        /// <summary>
        /// CountryCode
        /// </summary>
        [EnumMember(Value = "CountryCode")]
        CountryCode,

        /// <summary>
        /// LocalAuthorityClassificationTypeCode
        /// </summary>
        [EnumMember(Value = "LocalAuthorityClassificationTypeCode")]
        LocalAuthorityClassificationTypeCode,
    }
}
