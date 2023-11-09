using System.Data;

namespace Domain.Models.Global
{
    public class STPayInfo
    {
        public string szTxnType { get; set; } = "";
        public string szServiceID { get; set; } = "";
        public string szMerchantName { get; set; } = "";
        public string szGatewayID { get; set; } = "";
        public string szMerchantTxnID { get; set; } = "";
        public string szOrderNumber { get; set; } = "";
        public string szOrderDesc { get; set; } = "";
        public string szTxnAmount { get; set; } = "";
        public string szB4TaxAmt { get; set; } = "";         // Added by Jeff, 11 Mar 2015, for TuneDirect GST
        public string szTaxAmt { get; set; } = "";           // Added by Jeff, 11 Mar 2015, for TuneDirect GST
        public string szBaseTxnAmount { get; set; } = "";    // 3 Aug 2009, base currency booking confirmation enhancement
        public string szToTxnAmount { get; set; } = "";      // Added by Jeff, 10 Nov 2013
        public string szRTxnAmount { get; set; } = "";       // 11 Apr 2010, Reversal Sale transaction amount
        public string szCurrencyCode { get; set; } = "";
        public string szBaseCurrencyCode { get; set; } = ""; // 3 Aug 2009, base currency booking confirmation enhancement
        public string szFXCurrencyCode { get; set; } = "";   // Added by Jeff, 25 Aug 2014
        public string szFXTxnAmount { get; set; } = "";      // Added by Jeff, 25 Aug 2014
        public string szFXCurrencyRate { get; set; } = "";   // Added by Jeff, 26 Aug 2014
        public string szFXCurrencyMarkUp { get; set; } = ""; // Added by Jeff, 27 Aug 2014
        public string szFXCurrencyOriRate { get; set; } = ""; // Added by Jeff, 27 Aug 2014
        public string szRCurrencyCode { get; set; } = "";    // 11 Apr 2010, Reversal Sale currency code
        public string szIssuingBank { get; set; } = "";
        public string szLanguageCode { get; set; } = "";
        public string szCardPAN { get; set; } = "";
        public string szClearCardPAN { get; set; } = "";         // Added by Jeff, 17 May 2016, for OCP token creation
        public string szCardExp { get; set; } = "";              // Added by Jeff, 9 Oct 2015
        public string szCardHolder { get; set; } = "";           // Added by Jeff, 14 Dec 2013
        public string szCVV2 { get; set; } = "";
        public string szCardType { get; set; } = "";
        public string szCardTypeDesc { get; set; } = "";         // Added by Jeff, 9 Dec 2013
        public string szSessionID { get; set; } = "";
        public string szMerchantSessionID { get; set; } = "";    // Added by Jeff, 10 Jul 2014
        public string szMerchantReturnURL { get; set; } = "";
        public string szMerchantApprovalURL { get; set; } = "";      // Added by Jeff, 14 Jun 2014
        public string szMerchantUnApprovalURL { get; set; } = "";    // Added by Jeff, 14 Jun 2014
        public string szMerchantCancelURL { get; set; } = "";        // Added by Jeff, 2 Nov 2015
        public string szMerchantSupportURL { get; set; } = "";
        public string szRMerchantReturnURL { get; set; } = "";   // 11 Apr 2010, Reversal Sale Merchant Return URL
        public string szMerchantCallbackURL { get; set; } = "";  // Added by OoiMei, 16 Oct 2014
        public string szMerchantTermsURL { get; set; } = "";     // Added by Jeff, 15 Aug 2013
        public string szParam1 { get; set; } = "";               // Index (token) - length 100
        public string szParam2 { get; set; } = "";               // CardPAN - length 100
        public string szMaskedParam2 { get; set; } = "";
        public string szParam3 { get; set; } = "";               // Expired date - length 100
        public string szMaskedParam3 { get; set; } = "";
        public string szParam4 { get; set; } = "";               // Card holder name - length 100
        public string szParam5 { get; set; } = "";               // Card issuing bank - length 100
        public string szParam6 { get; set; } = "";               // Added on 16 Aug 2009, to cater for add seats - change to misc - length 50
        public string szParam7 { get; set; } = "";               // misc - length 50
        public string szParam8 { get; set; } = "";               // misc - length 50
        public string szParam9 { get; set; } = "";               // misc - length 50
        public string szParam10 { get; set; } = "";              // misc - length 50
        public string szParam11 { get; set; } = "";              // misc - length 255
        public string szParam12 { get; set; } = "";              // misc - length 255
        public string szParam13 { get; set; } = "";              // misc - length 255
        public string szParam14 { get; set; } = "";              // misc - length 255
        public string szParam15 { get; set; } = "";              // misc - length 255
        public string szParam16 { get; set; } = "";              // Added by HFM, 10 Apr 2020, Param16, to cater merchant send in, length 1000
        public string szParam17 { get; set; } = "";              // Added by Jon, 25 July 2023, MyDebit SRC enhancement
        public string szPanBin { get; set; } = "";               // Added by Jon, 25 July 2023, MyDebit SRC enhancement, to cater pan bin insertion where transaction uses TPAN
        public string szBinLastFour { get; set; } = "";          // Added by Jon, 25 July 2023, MyDebit SRC enhancement, to cater bin last four insertion where transaction uses TPAN
        public string szCorrelationId { get; set; } = "";        // Added by Jon, 25 July 2023, MyDebit SRC enhancement

        public string szHashMethod { get; set; } = "";
        public string szHashValue { get; set; } = "";
        public string szHashValue2 { get; set; } = "";           // Added by Jeff, 28 Apr 2016, response hash value 2 which includes OrderNumber and Param6 because some plugins like Magento update order based on these 2 fields
        public string szHashKey { get; set; } = "";
        public string szHashKeyLog { get; set; } = "";           // Added by Jeff, 16 Sep 2018, PCI
        public string szMerchantStreetAddress { get; set; } = ""; // Added by Christian C., 12 Apr 2018, new data to be included on Paymaya's addendum field.
        public string szMerchantCity { get; set; } = "";         // Added by OoiMei, 6 Jun 2014. Firefly FFCTB
        public string szMerchantState { get; set; } = "";        // Added by Christian C., 19 Mar 2020, 13 Jul 2018, Paymaya P3.
        public string szMerchantCountry { get; set; } = "";      // Added by OoiMei, 6 Jun 2014. Firefly FFCTB
        public string szMerchantAddress { get; set; } = "";      // Added by Jeff, 29 Jul 2013
        public string szMerchantContactNo { get; set; } = "";    // Added by Jeff, 29 Jul 2013
        public string szMerchantEmailAddr { get; set; } = "";    // Added by Jeff, 29 Jul 2013
        public string szMerchantNotifyEmailAddr { get; set; } = "";  // Added by Jeff, 8 Apr 2014
        public string szMerchantWebSiteURL { get; set; } = "";   // Added by Jeff, 29 Jul 2013
        public string szMerchantValidDomain { get; set; } = "";  // Added by Jeff, 11 Oct 2013
        public string szMerchantIP { get; set; } = "";           // Added by Jeff, 1 Aug 2013
        public string szPymtMethod { get; set; } = "";           // Added by Jeff, 11 Aug 2013
        public string szPMEntry { get; set; } = "0";              // Added by Jeff, 23 Aug 2013
        public string szFromRetrySvc { get; set; } = "0";         // Added by Jeff, 3 Oct 2013
        public bool bMultiEntries { get; set; } = false;          // Added by Jeff, 11 Oct 2013
        public string szTokenType { get; set; } = "";            // Added by Jeff, 17 Jul 2014
        public string szToken { get; set; } = "";                // Added by Jeff, 17 Jul 2014
        public string szToken2 { get; set; } = "";               // Added by Jeff, 30 May 2018
        public string szCustOCP { get; set; } = "";              // Added by Jeff, 8 Aug 2014
        public string szDDCountryCode { get; set; } = "";        // Added by Jeff, 25 Aug 2014
        public string szProtocol { get; set; } = "";             // Added by Jeff, 13 Sept 2016, to support callback resp protocol
        public string szAcqCountryCode { get; set; } = "";       // Added by Jeff, 24 Oct 2016, support fraud score email template by country

        public string szMaskedCardPAN { get; set; } = "";
        public string szTxnID { get; set; } = "";
        public string szMachineID { get; set; } = "";
        public string szRecv2ndEntry { get; set; } = "";     // e.g. BCA (UserID entry), Mandiri (Tokens info entry)
        public string szHTML { get; set; } = "";             // Added on 16 Mar 2010, to cater for Hosts Listing Page
        public string szRespContent { get; set; } = "";      // Added by Jeff, 11 Sept 2015, for Bitnet's response stream

        public double iPayAmount { get; set; } = 0.0; //
        public int iTxnType { get; set; } = 0; //              // 29 Feb 2016, HFM, Check and found no use, chg to store TrxType call from which szTrxType to query, 1=RSALE, 2=REFUND and Else=SALE
        public string szPostMethod { get; set; } = "";
        public string szTxnDateTime { get; set; } = "";     // Date Created
        public int iReqRes { get; set; } = 1;
        public int iTxnIDMaxLen { get; set; } = 0;          // Added on 30 Oct 2009
        public int iPKID { get; set; } = -1;                // Added by Jeff, 5 Sept 2013
        public int iQuantity { get; set; } = 1;             // Added by LeeLin, 8 Jun 2018, BNB Quantity
        public string szRecurrDuration { get; set; } = "";   // Added by LeeLin, 9 Aug 2018, Recurring
        public string szRecurrStartDate { get; set; } = "";  // Added by LeeLin, 16 July 2018, Recurring
        public string szRecurrEndDate { get; set; } = "";    // Added by LeeLin, 16 July 2018, Recurring
        public int iRecurrFreqNum { get; set; } = 0;         // Added by LeeLin, 16 July 2018, Recurring
        public string szRecurrFreqUnit { get; set; } = "";   // Added by LeeLin, 16 July 2018, Recurring
        public string szRecurrCriteria { get; set; } = "";   // Added by LeeLin, 16 July 2018, recurring criteria specified by merchant in payment request
        public string szCustRecurr { get; set; } = "";       // Added by LeeLin, 16 July 2018, customer recurring selection on or not
        public string szRecurrAmount { get; set; } = "";     // Added by LeeLin, 16 July 2018, Recurring
        public int iAllowQuantityDisplay { get; set; } = 0;  // Added by XY, 11 Oct 2018, BNB Quantity
        public string szTxnTypeX { get; set; } = "";         // Added by LeeLin, 14 Nov 2018, MPGS
        public string szTxnTypeQ { get; set; } = "";         // Added by Kelen, 14 Sept 2020, 6 Nov 2020, ALB MPGS
        public bool bUpdateParam { get; set; } = false;      // Added by LeeLin, 2 Apr 2021, PayLater

        // Merchant
        public string szMerchantName2 { get; set; } = "";       // Added by Christian C., 5 Oct 2017, field for merchant name from db even there's a merchant name on payment request.
        public string szMerchantPassword { get; set; } = "";
        public string szPaymentTemplate { get; set; } = "";
        public string szErrorTemplate { get; set; } = "";
        public string szRunningNo { get; set; } = "";
        public int iAllowReversal { get; set; } = 0;
        public int iAllowFDS { get; set; } = 0;                 // Added by Ooi Mei, Jul 2013
        public int iAllowExtFDS { get; set; } = 0;              // Added by Nick, 14 Mar 2016, fraudwall
        public int iCollectShipAddr { get; set; } = 0;          // Added by Jeff, 26 Jul 2013; Modified by Jeff, 29 Sept 2013, iAllowShipAddr to iCollectShipAddr
        public int iCollectBillAddr { get; set; } = 0;          // Added by Jeff, 25 Oct 2013
        public int iAllowMaxMind { get; set; } = 0;             // Added by Jeff, 6 Aug 2013
        public string szFraudByAmt { get; set; } = "";          // Added on 23 Jul 2013 by Ooi Mei. IPG
        public int iAllowPayment { get; set; } = 0;             // Added by Jeff, 7 Aug 2013
        public int iAllowQuery { get; set; } = 0;               // Added by Jeff, 7 Aug 2013
        public int iAllowDD { get; set; } = 0;                  // Added by Jeff, 7 Aug 2013
        public int iAllowOTC { get; set; } = 0;                 // Added by Jeff, 2 Sept 2014
        public int iAllowWallet { get; set; } = 0;              // Added by Jeff, 7 Aug 2013
        public int iAllowOCP { get; set; } = 0;                 // Added by Jeff, 17 Jul 2014
        public int iAllowCallBack { get; set; } = 0;            // Added by Jeff, 17 Jul 2014
        public int iAllowFX { get; set; } = 0;                  // Added by Jeff, 24 Jul 2014
        public int iRouteByParam1 { get; set; } = 0;            // Added by Jeff, 11 Apr 2014
        public int iPymtPageTimeout_S { get; set; }    // Added by Jeff, 26 Jul 2013; Modified by Jeff, 29 Sept 2013, iCardEntryTimeout_S to iPymtPageTimeout_S
        public int iCardTypeProfileID { get; set; }    // Added on 25 Jul 2013 by Ooi Mei. IPG
        public int i3DAccept { get; set; } = 3;                 // Added by Jeff, 28 Jul 2013
        public int iSelfMPI { get; set; } = 0;                  // Added by Ooi Mei, 22 May 2014, Firefly FF
        public int iVISA { get; set; } = 0;                     // Added by Jeff, 31 Jul 2013
        public int iMasterCard { get; set; } = 0;               // Added by Jeff, 31 Jul 2013
        public int iAMEX { get; set; } = 0;                     // Added by Jeff, 31 Jul 2013
        public int iJCB { get; set; } = 0;                      // Added by Jeff, 6 Aug 2013
        public int iDiners { get; set; } = 0;                   // Added by Jeff, 6 Aug 2013
        public int iCUP { get; set; } = 0;                      // Added by Jeff, 6 Aug 2013
        public int iMyDebitCNP { get; set; } = 0;               // Added by Jeff+Wai Hoong, 12 Dec 2022
        public int iMasterPass { get; set; } = 0;               // Added by OoiMei, 20 Sept 2016. MasterPass
        public int iVisaCheckout { get; set; } = 0;             // Added by OoiMei, 3 Apr 2017. VisaCheckout
        public int iSamsungPay { get; set; } = 0;               // Added by Vicky-SSP, 15 Oct 2017. SamsungPay
        public int iGooglePay { get; set; } = 0;                // Added by Christian C., 15 Apr 2019. GooglePay
        public int iPageTimeout { get; set; } = 0;              // Added by Jeff, 10 Aug 2013
        public int iSvcType { get; set; } = 0;                  // Added by Jeff, 23 Aug 2013
        public int iNeedAddOSPymt { get; set; } = 0;
        public int iTxnExpired_S { get; set; } = 0;             // Added by Jeff, 22 Sept 2013
        public int iReceipt { get; set; } = 0;                  // Added by Jeff, 29 Sept 2013
        public int iPymtNotificationEmail { get; set; } = 0;    // Added by Jeff, 29 Sept 2013
        public int iPymtNotificationSMS { get; set; } = 0;      // Added by Jeff, 29 Sept 2013
        public int iAutoReversal { get; set; } = 0;             // Added by Jeff, 3 Oct 2013
        public int iRespMethod { get; set; } = 1;               // Added by Jeff, 3 Oct 2013
        public double dPerTxnAmtLimit { get; set; } = 0;        // Added by Jeff, 7 Nov 2013
        public int iHCProfileID { get; set; } = 0;              // Added by Jeff, 5 Dec 2013, Direct Debit Host Country Profile ID
        public double dMerchFXRate { get; set; } = 0;           // Added by Jeff, 20 Aug 2014, Merchant Preferencial Foreign Exchange Rate (+/-)
        public int iShowMerchantAddr { get; set; } = 1;         // Added by Jeff, 2 Oct 2014
        public int iShowMerchantLogo { get; set; } = 1;         // Added by Jeff, 13 Oct 2014
        public string szExtraCSS { get; set; } = "";            // Added by Jeff, 14 Oct 2014
        public int iOTCExpiryHour { get; set; } = 0;            // Added by Jeff, 15 Apr 2015
        public int iReturnCardData { get; set; } = 0;           // Added by Jeff, 7 Oct 2015
        public string szSettleTAID { get; set; } = "";          // Added by Jeff, 3 May 2016, MOTO-Settle
        public string szSettleAmount { get; set; } = "";        // Added by Jeff, 3 May 2016, MOTO-Settle
        public string szSettleCount { get; set; } = "";         // Added by Jeff, 3 May 2016, MOTO-Settle
        public int iMCCCode { get; set; } = 0;                  // Added by Nick Fraudwall
        public int iFDSActionID { get; set; } = 0;              // Added by Nick Fraudwall
        public int iFDSRespCode { get; set; } = 0;              // Added by Nick Fraudwall
        public string szFDSCustomerID { get; set; } = "";       // Added by Nick Fraudwall
        public string szFDSAuthCode { get; set; } = "";         // Added by Nick Fraudwall
        public int iMyDebitSrc { get; set; } = 0; // Added by Jon, 8 Jun 2023. MyDebitSRC
        public int iMastercardC2P { get; set; } = 0;             // Added by Jon, 10 Jul 2023. MastercardC2P

        public string szFDSRespMsg { get; set; } = "";          // Added by Vicky-FW
        public string szFDSError { get; set; } = "";            // Added by Vicky-FW
        public string szFDSDeclineRule { get; set; } = "";      // Added by Vicky-FW
        public string szFDSScoreReason { get; set; } = "";      // Added by Vicky-FW
        public string szFDSEmailTemplate { get; set; } = "";    // Added by Vicky-FW

        public string szPostCode { get; set; } = "";            // Added by Christian C., 29 Mar 2017, for SMI/Paymaya

        public int iCVVRequire { get; set; } = 1;               // Added by Nick, 12 Feb 2018, Tik FX

        public int iAllowRefund { get; set; } = 0;              // Added by LeeLin, 8 Jun 2018, Allow Refund API

        public string szFailureCallBackNotifyEmailAddr { get; set; } = ""; // Added by LeeLin, 20 July 2018, Failure CallBack URL
        public string szChargeBackEmailAddr { get; set; } = "";            // Added by HFM, 20 July 2018, Refund Email Notif
        public string szMerchantMainContactEmail { get; set; } = "";       // Added by LeeLin, 20 July 2018, Refund Email Notif
        public string szMerchantMainContactNo { get; set; } = "";          // Added by LeeLin, 20 July 2018, Refund Email Notif
        public string szMerchantMainContactName { get; set; } = "";        // Added by LeeLin, 20 July 2018, Refund Email Notif
        public int iAllowRecurring { get; set; } = 0;                     // Added by LeeLin, 9 Aug 2018, Recurring
        public int iBDirectRefundNotify { get; set; } = 0;                // Added by LeeLin, 30 July 2018, B-Direct Refund Notification
        public int iAllowMPI { get; set; } = 0;                           // Added by Jawad, 6 Sep 2018, MPI
        public bool bMPIPaymentProcess { get; set; } = false;             // Added by Jawad, MPI, 6 Sep 2018
        public string szAcqBIN { get; set; } = "";                        // Added by Jawad, MPI, 6 Sep 2018
        public string szAcqBINType { get; set; } = "";                    // Added by Jawad, MPI, 6 Sep 2018
        public string szMPIId { get; set; } = "";                         // Added by Christian C., MPI, 3 Jan 2019
        public string szMPIMerchPwd { get; set; } = "";                   // Added by Jawad, MPI, 6 Sep 2018
        public string szMPITxnId { get; set; } = "";                      // Added by Jawad, MPI, 6 Sep 2018
        public string szPaReq { get; set; } = "";                         // Added by Jawad, MPI (Response), 6 Sep 2018
        public string szPaRes { get; set; } = "";                         // Added by Christian C., MPI (Response), 29 Jan 2019
        public string szMerchantStateData { get; set; } = "";             // Added by Jawad, MPI (Response), 6 Sep 2018
        public string szACSURL { get; set; } = "";                        // Added by Jawad, MPI (Response), 6 Sep 2018
        public string szEnrollStatus { get; set; } = "";                  // Added by Jawad, MPI (Response), 6 Sep 2018
        public string szErrorCode { get; set; } = "";                     // Added by Jawad, MPI (Response), 6 Sep 2018
        public string szTxStatus { get; set; } = "";                      // Added by Jawad, MPI, 6 Sep 2018
        public string szMPITxnStatus { get; set; } = "";                  // Added by Jawad, MPI, 6 Sep 2018
        public string szMPIAuthTxnStatus { get; set; } = "";              // Added by Jawad, MPI, 6 Sep 2018
        public string szMPITxnAmount { get; set; } = "";                  // Added by Jawad, MPI, 12 Sep 2018

        public string szMPIResTransID { get; set; } = "";                 // Added by HFM, 11 Jan 2021, 3DSS
        public string szMPIReqID { get; set; } = "";                      // Added by HFM, 11 Jan 2021, 3DSS
        public string szMPIReqName { get; set; } = "";                    // Added by HFM, 11 Jan 2021, 3DSS
        public string szMPIReqURL { get; set; } = "";                     // Added by HFM, 11 Jan 2021, 3DSS
        public string szMPIMerchantID { get; set; } = "";                 // Added by XinYi, 11 Jan 2021, 3DSS

        // Added by LeeLin, 13 Aug 2020, MDS Promotion
        public int iAllowPromo { get; set; } = 0;
        public int iPromoCodeFormat { get; set; } = 0;

        // Res to client
        public int iTxnStatus { get; set; } = -1;
        public int iTxnState { get; set; } = -1;
        public int iMerchantTxnStatus { get; set; } = -1;
        public int iQueryStatus { get; set; } = 2;
        public int iDuration { get; set; } = -1;

        // Res from Host
        public string szHostTxnID { get; set; } = "";
        public string szRespCode { get; set; } = "";
        public string szAuthCode { get; set; } = "";
        public string szBankRespMsg { get; set; } = "";
        public string szHostDate { get; set; } = "";
        public string szHostTime { get; set; } = "";
        public string szHostMID { get; set; } = "";
        public string szHostTID { get; set; } = "";
        public string szHostTxnStatus { get; set; } = "";
        public string szHostTxnAmount { get; set; } = "";
        public string szHostOrderNumber { get; set; } = "";
        public string szHostGatewayTxnID { get; set; } = "";
        public string szHostCurrencyCode { get; set; } = "";
        public string szHostTxnType { get; set; } = "";
        public string szEncryptKeyPath { get; set; } = "";
        public string szDecryptKeyPath { get; set; } = "";
        public string szRedirectURL { get; set; } = "";
        public string szECI { get; set; } = "";
        public string szPayerAuth { get; set; } = "";
        public string szAVS { get; set; } = "";
        public string szHostTtlRefundAmt { get; set; } = "0";
        public string szHostRefundTxnID { get; set; } = "";
        public string szHostTtlCaptureAmt { get; set; } = "0";
        public string szReserved { get; set; } = "";

        public int iAction { get; set; } = 0;
        public bool bVerified { get; set; } = true;

        public int iOSRet { get; set; } = 99;
        public int iErrSet { get; set; } = -1;
        public int iErrNum { get; set; } = -1;

        public int iHttpTimeoutSeconds { get; set; } = 0;

        public string szTxnMsg { get; set; } = "";
        public string szQueryMsg { get; set; } = "";
        public string szErrDesc { get; set; } = "";
        public string szDate { get; set; } = "";
        public string szTime { get; set; } = "";

        // Set to true to send request to bank in JSON Format
        public bool bIsJsonRequest { get; set; } = false; // Added by Arif, 28 Jan 2018
        public Dictionary<string, object>? dctJsonRequest { get; set; } = null; // Added by Arif, 28 Jan 2018
        public Dictionary<string, object>? dctJsonRequestOption { get; set; } = null; // Added by Arif, 28 Jan 2018

        // Set to true to response with JSON Format
        // Add Response data into dctJsonResponse
        public bool bIsJsonResponse { get; set; } = false; // Added by Arif, 30 May 2018
        public Dictionary<string, object>? dctJsonResponse { get; set; } = null; // Added by Arif, 30 May 2018. Modified by Arif, 28 Jan 2019, changed 2nd constructor param type from String to Object

        public string szCustIP { get; set; } = ""; // Added on 23 Jul 2013 by Ooi Mei. IPG
        public string szBillAddr { get; set; } = "";
        public string szBillCity { get; set; } = "";
        public string szBillRegion { get; set; } = "";
        public string szBillPostal { get; set; } = "";
        public string szBillCountry { get; set; } = ""; // Added by Jeff, 31 Jul 2013
        public string szShipAddr { get; set; } = "";
        public string szShipCity { get; set; } = "";
        public string szShipRegion { get; set; } = "";
        public string szShipPostal { get; set; } = "";
        public string szShipCountry { get; set; } = ""; // Added by Jeff, 31 Jul 2013
        public string szCustName { get; set; } = ""; // Added by Jeff, 23 Aug 2013
        public string szCustEmail { get; set; } = "";
        public string szCustPhone { get; set; } = "";
        public string szCustMAC { get; set; } = ""; // Added by Jeff, 23 Aug 2013
        public string szBINCountry { get; set; } = ""; // Added by Jeff, 3 Oct 2013
        public string szBINName { get; set; } = "";
        public string szBINPhone { get; set; } = "";

        // Added by OoiMei, 19 May 2014, Firefly FF
        public string szCAVV { get; set; } = ""; // 40 character. eg: AAABCJFQEQAAAAABkFARAAAAAAA=
        public string sz3dsXID { get; set; } = ""; // 40 character. eg: NHRkRExIcmhUSHJ3WHFoOU9BMjA=
        public string sz3DFlag { get; set; } = ""; // 5 character. eg: 01VYY
        public string sz3dsEnrolled { get; set; } = ""; // 1 character which is from sz3DFlag.Substring(3, 1) = Y
        public string sz3dsStatus { get; set; } = ""; // 1 character which is from sz3DFlag.Substring(4, 1) = Y
        public string szMPICode { get; set; } = ""; // 1 character which is from sz3DFlag.Substring(0,1) = 0 (Success). Added by OoiMei, 13 Jun 2014, Firefly FFCIMB

        public string szUUID { get; set; } = "";
        public string szUTCDateTime { get; set; } = "";
        public string szAirlineCode { get; set; } = ""; // Added by OoiMei, 3 March 2015. Reuse AirlineCode as Trxn Security Code for GPay Reversal.

        public string szOTCSecureCode { get; set; } = "";
        public string szReqTime { get; set; } = "";
        public string szDueTime { get; set; } = "";
        public string szHostCountryName { get; set; } = ""; // Added by HFM, display in OTC receipt

        public string szCTxnAmount { get; set; } = "";
        public string szCCurrencyCode { get; set; } = "";
        public bool bRespCodeCS { get; set; } = false; // Added by OoiMei, 25 Aug 2016.
        public string szTotCaptureAmt { get; set; } = ""; // Added by OoiMei, 30 Aug 2016.
        public string szGatewayCaptureTxnID { get; set; } = ""; // Added by HFM, 4 Nov 2019, 10 Apr 2020, AliPayAuth

        // Added by OoiMei, 10 Jul 2015. REFUND
        public string szTxnAmountOri { get; set; } = "";
        public string szTotRefundAmt { get; set; } = "";

        // Added by HFM, 20 Nov 2015. Promotion
        public int iPromoExist { get; set; } = -1;
        public List<string>? lPromoList { get; set; } = null;
        public int iPromoID { get; set; } = -1;
        public string szPromoCode { get; set; } = "";
        public string szPromoOriAmt { get; set; } = "";
        public string szPromotion { get; set; } = "";
        public int iPromoActionID { get; set; } = 0;
        public int iPromoConfirmID { get; set; } = 0;

        // Added by Alex, 11 Oct 2018. Promotion
        public DataTable? dtPromoBinRange { get; set; } = null;
        
        public int iValidPromoCode { get; set; } = 0;
        public string szEntitleOtherPromo { get; set; } = "";
        public int iPromoType { get; set; } = 0;
        public string szPromoListV2 { get; set; } = "";
        public int iPromoIsApply { get; set; } = 0;

        // Added by OoiMei, 25 Nov 2015. Installment
        public int iInstallment { get; set; } = 0;
        public string szInstallPlan { get; set; } = "";
        public string szInstallMthTerm { get; set; } = "";
        public int iAllowInstallment { get; set; } = 0;
        public int iEntitleInstallment { get; set; } = 0;

        // Added by Vicky-711, 25 May 2016
        public string szDetailID { get; set; } = "";

        // Added by OoiMei, 2 Aug 2016. HostGroup for FPX2D
        public string szHGBankID { get; set; } = "";

        // Added by OoiMei, 10 Oct 2016. MasterPass
        public string szWalletID { get; set; } = "";
        public string szCheckoutStatus { get; set; } = "";
        public string szLongAccessToken { get; set; } = "";
        public string szPreCheckoutTxnID { get; set; } = "";
        public string szPreCheckoutCardLast4 { get; set; } = "";
        public string szPreCheckoutCardId { get; set; } = "";
        public string szPreCheckoutAddrId { get; set; } = "";
        public string szReqToken { get; set; } = ""; // Added 9 Jan 2017
        public string szPairingReqToken { get; set; } = ""; // Added 9 Jan 2017
        public string szReqVerifier { get; set; } = ""; // Added 10 Jan 2017
        public string szPairingVerifier { get; set; } = ""; // Added 10 Jan 2017
        public string szCheckoutResourceURL { get; set; } = ""; // Added 10 Jan 2017
        public string szCardList { get; set; } = ""; // Added 25 Feb 2017 - Masterpass-2
        public string szHostTxnState { get; set; } = ""; // Added by Vicky-BTP, 26 Dec 2017
        public int iGMTDiffMins { get; set; } = 0; // Added by Vicky-OTC, 21 Feb 2017, to get host country local time
        public STQrAndBarCodeInfo stQrAndBarcodeInfo { get; set; } = new STQrAndBarCodeInfo(); // Added by Alex Ng Nkh, 15 Jan 2019, Barcode and Qrcode.
        public uint iCustIPNumeric { get; set; } = 0; // Added by LeeLin, 28 Feb 2019, Malindo
        public string szMerchantRiskEmail { get; set; } = ""; // Added by LeeLin, 28 Feb 2019, Malindo
        public string szIPCountry { get; set; } = ""; // Added by LeeLin, 28 Feb 2019, Malindo
        public string szIATACountry { get; set; } = ""; // Added by LeeLin, 28 Feb 2019, Malindo
        public string szCardBINCountry { get; set; } = ""; // Added by LeeLin, 28 Feb 2019, Malindo
        public int iFraudRet { get; set; } = 0; // Added by LeeLin, 28 Feb 2019, Malindo
        public string szPostMethodOri { get; set; } = ""; // Added by HFM+Jeff, 19 Aug 2019, Boost
        public bool bMobileBrowser { get; set; } = false; // Added by XinYi, 25 Oct 2019, TNG
        public bool bGetHashValueOnly { get; set; } = false; // Added by XinYi, 25 Oct 2019, TNG
        public int iTokenMethod { get; set; } = 0; // Added by XinYi, 9 Feb 2020, M4M, Merchant Token Method
        public int iMerchantRefundNotify { get; set; } = 0; // Added by XinYi, 31 Mar 2020, Atomy refund notification to merchant
        public string szCustID { get; set; } = ""; // Added by HFM, 21 Apr 2020, FPX Payer Identity

        public int iVIS { get; set; } = 0; // Added by Chewwai, 25 August 2020, 31 Oct 2020, VISA installment API - based on merchant settings
        public string szInstPlanID { get; set; } = ""; // Added by ChewWai, VISA installment, confirmPlan parameter
        public string szInstTncUrl { get; set; } = ""; // Added by ChewWai, VISA installment, confirmPlan parameter
        public string szInstTncVer { get; set; } = ""; // Added by ChewWai, VISA installment, confirmPlan parameter
        public int iInstNum { get; set; } = 0; // Added by ChewWai, VISA installment, confirmPlan parameter Number of installment payments required
        public string szInstFreq { get; set; } = ""; // Added by ChewWai, VISA installment, confirmPlan parameter Installment frequency, e.g.: "WEEKLY","MONTHLY","BIWEEKLY"
        public int iInstStatus { get; set; } = 0; // Added by ChewWai, VISA Installment, installment status
        public int iMyDebit { get; set; } = 0; // Added by XinYi, 11 Jan 2021, 3DSS, MyDebit
        public string szCaptureHostTxnID { get; set; } = ""; // Added by LL, 29 Nov 2020, PBB CYBS
        public string szPaymentNotificationTemplate { get; set; } = ""; // Added by Kelen, 2 Nov 2020, 6 Nov 2020, Payment Notification Template
        public string szCardBINCountryCode { get; set; } = ""; // Added by Christian C, 27 Jan 2021, 11 Mar 2021, CIMB Niaga ID, get card issuer bank country code
        public int iIsFromSDK { get; set; } = 0; // Added by XinYi, 1 Sept 2021, Atome, indicator to check if the request is from SDK
        public string szBrowserData { get; set; } = ""; // Added by XinYi, 1 Sept 2021, Cherri browserColorDepth enhancement
        public string szMerchantCountry3 { get; set; } = ""; // Added by LWC, 12 Sept 2021, ALB2

        public int i3DS2AuthStatus { get; set; } = -3; // Added by LWC, 21 Dec 2021, RHBMPGS
        public string sz3DSAuthTxnID { get; set; } = ""; // Added by LWC, 21 Dec 2021, RHBMPGS
        public string szHostName { get; set; } = ""; // Added by LWC, 21 Dec 2021, RHBMPGS
        public bool bBrowserJavaEnabled { get; set; } = false; // Added by LWC, 21 Dec 2021, RHBMPGS
        public string szBrowserLanguage { get; set; } = ""; // Added by LWC, 21 Dec 2021, RHBMPGS
        public string szBrowserColorDepth { get; set; } = ""; // Added by LWC, 21 Dec 2021, RHBMPGS
        public string szBrowserScreenHeight { get; set; } = ""; // Added by LWC, 21 Dec 2021, RHBMPGS
        public string szBrowserScreenWidth { get; set; } = ""; // Added by LWC, 21 Dec 2021, RHBMPGS
        public string szBrowserTZ { get; set; } = ""; // Added by LWC, 21 Dec 2021, RHBMPGS
        public string szAcceptHeader { get; set; } = ""; // Added by LWC, 21 Dec 2021, RHBMPGS
        public string szIssuerFIID { get; set; } = ""; // Added by Alex Ng Nkh, 24 Sep 2021, 21 Dec 2021, for MyDebit CNP (NKH001CNP). the variable holds the value of the credit card's FIID.
        public string szAuthOriTxnAmount { get; set; } = ""; // Added by LWC, CIMB3DS2.0, 20 Apr 2022, 25 Apr 2022
        public string szReqBody { get; set; } = ""; // Added by LWC, MBBMGATE, 20 Jun 2022
        public string szMerchantHostParam1 { get; set; } = ""; // Added by XinYi, MBBMGATE, 20 Jun 2022
        public string szMerchantHostParam2 { get; set; } = ""; // Added by XinYi, MBBMGATE, 20 Jun 2022

        public bool bIs3DS2ThruPP { get; set; } = false; // Added by LL, 3DS2 flow enhancement, 20 Jun 2022

        public string iCheckTtlRefundAmt { get; set; } = "1"; // Added by LWC, CIMB3DS2.0, 1 Jun 2022, 20 Jun 2022
        public string szHttpContent { get; set; } = ""; // Added by Liwen, TMB 2022-12-05 7 Feb 2023
        public bool bBNBTxn { get; set; } = false; // Added by Jeff, 22 May 2023, MyDebitCNP BNB
        public int iCustomErrHandling { get; set; } = 0;

        public string? szHostToken { get; set; } = null; // Added by Kelvin, MBBMGate Tokenization , 31 Mar 2023
        public string? szTokenUniqueReference { get; set; } = null;
        public string? szTokenExpiry { get; set; } = null;
        public string? szTokenStatus { get; set; } = null;
        public string? szTokenProvider { get; set; } = null;
    }
}
