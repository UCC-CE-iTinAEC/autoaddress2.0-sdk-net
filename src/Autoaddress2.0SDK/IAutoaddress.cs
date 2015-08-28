﻿using System.Threading.Tasks;

namespace Autoaddress.Autoaddress2_0
{
    /// <summary>
    /// Interface for accessing the Autoaddress 2.0 service.
    /// </summary>
    public interface IAutoaddress
    {
        /// <summary>
        /// Lookup a Postcode or Address. Returns all available data if found.
        /// </summary>
        /// <param name="request">FindAddress request.</param>
        /// <returns>FindAddress response.</returns>
        Model.FindAddress.Response FindAddress(Model.FindAddress.Request request);

        /// <summary>
        /// Lookup a Postcode or Address. Returns all available data if found.
        /// </summary>
        /// <param name="link">A link returned in a FindAddress response.</param>
        /// <returns>FindAddress response.</returns>
        Model.FindAddress.Response FindAddress(Model.FindAddress.Link link);

        /// <summary>
        /// Lookup a Postcode or Address as an asynchronous operation. Returns all available data if found.
        /// </summary>
        /// <param name="request">FindAddress request.</param>
        /// <returns>FindAddress response.</returns>
        Task<Model.FindAddress.Response> FindAddressAsync(Model.FindAddress.Request request);

        /// <summary>
        /// Lookup a Postcode or Address as an asynchronous operation. Returns all available data if found.
        /// </summary>
        /// <param name="link">A link returned in a FindAddress response.</param>
        /// <returns>FindAddress response.</returns>
        Task<Model.FindAddress.Response> FindAddressAsync(Model.FindAddress.Link link);

        /// <summary>
        /// Lookup a Postcode. Returns all available data if found.
        /// </summary>
        /// <param name="request">PostcodeLookup request.</param>
        /// <returns>PostcodeLookup response.</returns>
        Model.PostcodeLookup.Response PostcodeLookup(Model.PostcodeLookup.Request request);

        /// <summary>
        /// Lookup a Postcode. Returns all available data if found.
        /// </summary>
        /// <param name="link">A link returned in a PostcodeLookup response.</param>
        /// <returns>PostcodeLookup response.</returns>
        Model.PostcodeLookup.Response PostcodeLookup(Model.PostcodeLookup.Link link);

        /// <summary>
        /// Lookup a Postcode as an asynchronous operation. Returns all available data if found.
        /// </summary>
        /// <param name="request">PostcodeLookup request.</param>
        /// <returns>PostcodeLookup response.</returns>
        Task<Model.PostcodeLookup.Response> PostcodeLookupAsync(Model.PostcodeLookup.Request request);

        /// <summary>
        /// Lookup a Postcode as an asynchronous operation. Returns all available data if found.
        /// </summary>
        /// <param name="link">A link returned in a PostcodeLookup response.</param>
        /// <returns>PostcodeLookup response.</returns>
        Task<Model.PostcodeLookup.Response> PostcodeLookupAsync(Model.PostcodeLookup.Link link);
        
        /// <summary>
        /// Verify that the address supplied matches the Eircode supplied.
        /// </summary>
        /// <param name="request">VerifyAddress request.</param>
        /// <returns>VerifyAddress response.</returns>
        Model.VerifyAddress.Response VerifyAddress(Model.VerifyAddress.Request request);

        /// <summary>
        /// Verify that the address supplied matches the Eircode supplied.
        /// </summary>
        /// <param name="link">A link returned in a VerifyAddress response.</param>
        /// <returns>VerifyAddress response.</returns>
        Model.VerifyAddress.Response VerifyAddress(Model.VerifyAddress.Link link);

        /// <summary>
        /// Verify that the address supplied matches the Eircode supplied as an asynchronous operation.
        /// </summary>
        /// <param name="request">VerifyAddress request.</param>
        /// <returns>VerifyAddress response.</returns>
        Task<Model.VerifyAddress.Response> VerifyAddressAsync(Model.VerifyAddress.Request request);
        
        /// <summary>
        /// Verify that the address supplied matches the Eircode supplied as an asynchronous operation.
        /// </summary>
        /// <param name="link">A link returned in a VerifyAddress response.</param>
        /// <returns>VerifyAddress response.</returns>
        Task<Model.VerifyAddress.Response> VerifyAddressAsync(Model.VerifyAddress.Link link);

        /// <summary>
        /// Return all the available data from the ECAD for the supplied ECAD Id.
        /// </summary>
        /// <param name="request">GetEcadData request.</param>
        /// <returns>GetEcadData response.</returns>
        Model.GetEcadData.Response GetEcadData(Model.GetEcadData.Request request);

        /// <summary>
        /// Return all the available data from the ECAD for the supplied ECAD Id.
        /// </summary>
        /// <param name="link">A link returned in a GetEcadData response.</param>
        /// <returns>GetEcadData response.</returns>
        Model.GetEcadData.Response GetEcadData(Model.GetEcadData.Link link);
        
        /// <summary>
        /// Return all the available data from the ECAD for the supplied ECAD Id as an asynchronous operation.
        /// </summary>
        /// <param name="request">GetEcadData request.</param>
        /// <returns>GetEcadData response.</returns>
        Task<Model.GetEcadData.Response> GetEcadDataAsync(Model.GetEcadData.Request request);
        
        /// <summary>
        /// Return all the available data from the ECAD for the supplied ECAD Id as an asynchronous operation.
        /// </summary>
        /// <param name="link">A link returned in a GetEcadData response.</param>
        /// <returns>GetEcadData response.</returns>
        Task<Model.GetEcadData.Response> GetEcadDataAsync(Model.GetEcadData.Link link);
    }
}