using System.Data;

namespace Domain.Models.Structure
{
    public class STPayInfo
    {
        //public string szTxnType;
        //public string szServiceID;
        //public string szMerchantName;
        //public string szGatewayID;
        //public string szMerchantTxnID;
        //public string szOrderNumber;
        //public string szOrderDesc;
        //public string szTxnAmount;
        //public string szB4TaxAmt;         // Added by Jeff, 11 Mar 2015, for TuneDirect GST
        //public string szTaxAmt;           // Added by Jeff, 11 Mar 2015, for TuneDirect GST
        //public string szBaseTxnAmount;    // 3 Aug 2009, base currency booking confirmation enhancement
        //public string szToTxnAmount;      // Added by Jeff, 10 Nov 2013
        //public string szRTxnAmount;       // 11 Apr 2010, Reversal Sale transaction amount
        //public string szCurrencyCode;
        //public string szBaseCurrencyCode; // 3 Aug 2009, base currency booking confirmation enhancement
        //public string szFXCurrencyCode;   // Added by Jeff, 25 Aug 2014
        //public string szFXTxnAmount;      // Added by Jeff, 25 Aug 2014
        //public string szFXCurrencyRate;   // Added by Jeff, 26 Aug 2014
        //public string szFXCurrencyMarkUp; // Added by Jeff, 27 Aug 2014
        //public string szFXCurrencyOriRate; // Added by Jeff, 27 Aug 2014
        //public string szRCurrencyCode;    // 11 Apr 2010, Reversal Sale currency code
        //public string szIssuingBank;
        //public string szLanguageCode;
        //public string szCardPAN;
        //public string szClearCardPAN;         // Added by Jeff, 17 May 2016, for OCP token creation
        //public string szCardExp;              // Added by Jeff, 9 Oct 2015
        //public string szCardHolder;           // Added by Jeff, 14 Dec 2013
        //public string szCVV2;
        //public string szCardType;
        //public string szCardTypeDesc;         // Added by Jeff, 9 Dec 2013
        //public string szSessionID;
        //public string szMerchantSessionID;    // Added by Jeff, 10 Jul 2014
        //public string szMerchantReturnURL;
        //public string szMerchantApprovalURL;      // Added by Jeff, 14 Jun 2014
        //public string szMerchantUnApprovalURL;    // Added by Jeff, 14 Jun 2014
        //public string szMerchantCancelURL;        // Added by Jeff, 2 Nov 2015
        //public string szMerchantSupportURL;
        //public string szRMerchantReturnURL;   // 11 Apr 2010, Reversal Sale Merchant Return URL
        //public string szMerchantCallbackURL;  // Added by OoiMei, 16 Oct 2014
        //public string szMerchantTermsURL;     // Added by Jeff, 15 Aug 2013
        //public string szParam1;               // Index (token) - length 100
        //public string szParam2;               // CardPAN - length 100
        //public string szMaskedParam2;
        //public string szParam3;               // Expired date - length 100
        //public string szMaskedParam3;
        //public string szParam4;               // Card holder name - length 100
        //public string szParam5;               // Card issuing bank - length 100
        //public string szParam6;               // Added on 16 Aug 2009, to cater for add seats - change to misc - length 50
        //public string szParam7;               // misc - length 50
        //public string szParam8;               // misc - length 50
        //public string szParam9;               // misc - length 50
        //public string szParam10;              // misc - length 50
        //public string szParam11;              // misc - length 255
        //public string szParam12;              // misc - length 255
        //public string szParam13;              // misc - length 255
        //public string szParam14;              // misc - length 255
        //public string szParam15;              // misc - length 255
        //public string szParam16;              // Added by HFM, 10 Apr 2020, Param16, to cater merchant send in, length 1000
        //public string szParam17;              // Added by Jon, 25 July 2023, MyDebit SRC enhancement
        //public string szPanBin;               // Added by Jon, 25 July 2023, MyDebit SRC enhancement, to cater pan bin insertion where transaction uses TPAN
        //public string szBinLastFour;          // Added by Jon, 25 July 2023, MyDebit SRC enhancement, to cater bin last four insertion where transaction uses TPAN
        //public string szCorrelationId;        // Added by Jon, 25 July 2023, MyDebit SRC enhancement

        //public string szHashMethod;
        //public string szHashValue;
        //public string szHashValue2;           // Added by Jeff, 28 Apr 2016, response hash value 2 which includes OrderNumber and Param6 because some plugins like Magento update order based on these 2 fields
        //public string szHashKey;
        //public string szHashKeyLog;           // Added by Jeff, 16 Sep 2018, PCI
        //public string szMerchantStreetAddress; // Added by Christian C., 12 Apr 2018, new data to be included on Paymaya's addendum field. 
        //public string szMerchantCity;         // Added by OoiMei, 6 Jun 2014. Firefly FFCTB
        //public string szMerchantState;        // Added by Christian C., 19 Mar 2020, 13 Jul 2018, Paymaya P3. 
        //public string szMerchantCountry;      // Added by OoiMei, 6 Jun 2014. Firefly FFCTB
        //public string szMerchantAddress;      // Added by Jeff, 29 Jul 2013
        //public string szMerchantContactNo;    // Added by Jeff, 29 Jul 2013
        //public string szMerchantEmailAddr;    // Added by Jeff, 29 Jul 2013
        //public string szMerchantNotifyEmailAddr;  // Added by Jeff, 8 Apr 2014
        //public string szMerchantWebSiteURL;   // Added by Jeff, 29 Jul 2013
        //public string szMerchantValidDomain;  // Added by Jeff, 11 Oct 2013
        //public string szMerchantIP;           // Added by Jeff, 1 Aug 2013
        //public string szPymtMethod;           // Added by Jeff, 11 Aug 2013
        //public string szPMEntry;              // Added by Jeff, 23 Aug 2013
        //public string szFromRetrySvc;         // Added by Jeff, 3 Oct 2013
        //public bool bMultiEntries;            // Added by Jeff, 11 Oct 2013
        //public string szTokenType;            // Added by Jeff, 17 Jul 2014
        //public string szToken;                // Added by Jeff, 17 Jul 2014
        //public string szToken2;               // Added by Jeff, 30 May 2018
        //public string szCustOCP;              // Added by Jeff, 8 Aug 2014
        //public string szDDCountryCode;        // Added by Jeff, 25 Aug 2014
        //public string szProtocol;             // Added by Jeff, 13 Sept 2016, to support callback resp protocol
        //public string szAcqCountryCode;       // Added by Jeff, 24 Oct 2016, support fraud score email template by country

        //public string szMaskedCardPAN;
        //public string szTxnID;
        //public string szMachineID;
        //public string szRecv2ndEntry;     // e.g. BCA (UserID entry), Mandiri (Tokens info entry)
        //public string szHTML;             // Added on 16 Mar 2010, to cater for Hosts Listing Page
        //public string szRespContent;      // Added by Jeff, 11 Sept 2015, for Bitnet's response stream

        //public double iPayAmount;
        //public int iTxnType;              // 29 Feb 2016, HFM, Check and found no use, chg to store TrxType call from which szTrxType to query, 1=RSALE, 2=REFUND and Else=SALE
        //public string szPostMethod;
        //public string szTxnDateTime;      // Date Created
        //public int iReqRes;
        //public int iTxnIDMaxLen;          // Added on 30 Oct 2009
        //public int iPKID;                 // Added by Jeff, 5 Sept 2013
        //public int iQuantity;             // Added by LeeLin, 8 Jun 2018, BNB Quantity
        //public string szRecurrDuration;    // Added by LeeLin, 9 Aug 2018, Recurring
        //public string szRecurrStartDate;   // Added by LeeLin, 16 July 2018, Recurring
        //public string szRecurrEndDate;     // Added by LeeLin, 16 July 2018, Recurring
        //public int iRecurrFreqNum;         // Added by LeeLin, 16 July 2018, Recurring
        //public string szRecurrFreqUnit;    // Added by LeeLin, 16 July 2018, Recurring
        //public string szRecurrCriteria;    // Added by LeeLin, 16 July 2018, recurring criteria specified by merchant in payment request
        //public string szCustRecurr;        // Added by LeeLin, 16 July 2018, customer recurring selection on or not
        //public string szRecurrAmount;      // Added by LeeLin, 16 July 2018, Recurring
        //public int iAllowQuantityDisplay;  // Added by XY, 11 Oct 2018, BNB Quantity
        //public string szTxnTypeX;         // Added by LeeLin, 14 Nov 2018, MPGS
        //public string szTxnTypeQ;         // Added by Kelen, 14 Sept 2020, 6 Nov 2020, ALB MPGS
        //public bool bUpdateParam;         // Added by LeeLin, 2 Apr 2021, PayLater

        // Merchant
        //public string szMerchantName2;        // Added by Christian C., 5 Oct 2017, field for merchant name from db even there's a merchant name on payment request.
        //public string szMerchantPassword;
        //public string szPaymentTemplate;
        //public string szErrorTemplate;
        //public string szRunningNo;
        //public int iAllowReversal;
        //public int iAllowFDS;             // Added by Ooi Mei, Jul 2013
        //public int iAllowExtFDS;          // Added by Nick, 14 Mar 2016, fraudwall
        //public int iCollectShipAddr;      // Added by Jeff, 26 Jul 2013; Modified by Jeff, 29 Sept 2013, iAllowShipAddr to iCollectShipAddr
        //public int iCollectBillAddr;      // Added by Jeff, 25 Oct 2013
        //public int iAllowMaxMind;         // Added by Jeff, 6 Aug 2013
        //public string szFraudByAmt;       // Added on 23 Jul 2013 by Ooi Mei. IPG
        //public int iAllowPayment;         // Added by Jeff, 7 Aug 2013
        //public int iAllowQuery;           // Added by Jeff, 7 Aug 2013
        //public int iAllowDD;              // Added by Jeff, 7 Aug 2013
        //public int iAllowOTC;             // Added by Jeff, 2 Sept 2014
        //public int iAllowWallet;          // Added by Jeff, 7 Aug 2013
        //public int iAllowOCP;             // Added by Jeff, 17 Jul 2014
        //public int iAllowCallBack;        // Added by Jeff, 17 Jul 2014
        //public int iAllowFX;              // Added by Jeff, 24 Jul 2014
        //public int iRouteByParam1;        // Added by Jeff, 11 Apr 2014
        //public int iPymtPageTimeout_S;    // Added by Jeff, 26 Jul 2013; Modified by Jeff, 29 Sept 2013, iCardEntryTimeout_S to iPymtPageTimeout_S
        //public int iCardTypeProfileID;    // Added on 25 Jul 2013 by Ooi Mei. IPG
        //public int i3DAccept;             // Added by Jeff, 28 Jul 2013
        //public int iSelfMPI;              // Added by Ooi Mei, 22 May 2014, Firefly FF
        //public int iVISA;                 // Added by Jeff, 31 Jul 2013
        //public int iMasterCard;           // Added by Jeff, 31 Jul 2013
        //public int iAMEX;                 // Added by Jeff, 31 Jul 2013
        //public int iJCB;                  // Added by Jeff, 6 Aug 2013
        //public int iDiners;               // Added by Jeff, 6 Aug 2013
        //public int iCUP;                  // Added by Jeff, 6 Aug 2013
        //public int iMyDebitCNP;           // Added by Jeff+Wai Hoong, 12 Dec 2022
        //public int iMasterPass;           // Added by OoiMei, 20 Sept 2016. MasterPass
        //public int iVisaCheckout;         // Added by OoiMei, 3 Apr 2017. VisaCheckout
        //public int iSamsungPay;           // Added by Vicky-SSP, 15 Oct 2017. SamsungPay
        //public int iGooglePay;            // Added by Christian C., 15 Apr 2019. GooglePay
        //public int iPageTimeout;          // Added by Jeff, 10 Aug 2013
        //public int iSvcType;              // Added by Jeff, 23 Aug 2013
        //public int iNeedAddOSPymt;
        //public int iTxnExpired_S;         // Added by Jeff, 22 Sept 2013
        //public int iReceipt;                   // Added by Jeff, 29 Sept 2013
        //public int iPymtNotificationEmail;     // Added by Jeff, 29 Sept 2013
        //public int iPymtNotificationSMS;       // Added by Jeff, 29 Sept 2013
        //public int iAutoReversal;              // Added by Jeff, 3 Oct 2013
        //public int iRespMethod;                // Added by Jeff, 3 Oct 2013
        //public double dPerTxnAmtLimit;         // Added by Jeff, 7 Nov 2013
        //public int iHCProfileID;               // Added by Jeff, 5 Dec 2013, Direct Debit Host Country Profile ID
        //public double dMerchFXRate;            // Added by Jeff, 20 Aug 2014, Merchant Preferencial Foreign Exchange Rate (+/-)
        //public int iShowMerchantAddr;          // Added by Jeff, 2 Oct 2014
        //public int iShowMerchantLogo;          // Added by Jeff, 13 Oct 2014
        //public string szExtraCSS;              // Added by Jeff, 14 Oct 2014
        //public int iOTCExpiryHour;             // Added by Jeff, 15 Apr 2015
        //public int iReturnCardData;            // Added by Jeff, 7 Oct 2015
        //public string szSettleTAID;            // Added by Jeff, 3 May 2016, MOTO-Settle
        //public string szSettleAmount;          // Added by Jeff, 3 May 2016, MOTO-Settle
        //public string szSettleCount;           // Added by Jeff, 3 May 2016, MOTO-Settle
        //public int iMCCCode;                   // Added by Nick Fraudwall
        //public int iFDSActionID;               // Added by Nick Fraudwall
        //public int iFDSRespCode;               // Added by Nick Fraudwall
        //public string szFDSCustomerID;         // Added by Nick Fraudwall
        //public string szFDSAuthCode;           // Added by Nick Fraudwall
        //public int iMyDebitSrc;                // Added by Jon, 8 Jun 2023. MyDebitSRC
        //public int iMastercardC2P;             // Added by Jon, 10 Jul 2023. MastercardC2P

        //public string szFDSRespMsg;            // Added by Vicky-FW
        //public string szFDSError;              // Added by Vicky-FW
        //public string szFDSDeclineRule;        // Added by Vicky-FW
        //public string szFDSScoreReason;        // Added by Vicky-FW
        //public string szFDSEmailTemplate;      // Added by Vicky-FW

        //public string szPostCode;              // Added by Christian C., 29 Mar 2017, for SMI/Paymaya

        //public int iCVVRequire;                // Added by Nick, 12 Feb 2018, Tik FX

        //public int iAllowRefund;               // Added by LeeLin, 8 Jun 2018, Allow Refund API

        //public string szFailureCallBackNotifyEmailAddr; // Added by LeeLin, 20 July 2018, Failure CallBack URL
        //public string szChargeBackEmailAddr;            // Added by HFM, 20 July 2018, Refund Email Notif
        //public string szMerchantMainContactEmail;       // Added by LeeLin, 20 July 2018, Refund Email Notif
        //public string szMerchantMainContactNo;          // Added by LeeLin, 20 July 2018, Refund Email Notif
        //public string szMerchantMainContactName;        // Added by LeeLin, 20 July 2018, Refund Email Notif
        //public int iAllowRecurring;                     // Added by LeeLin, 9 Aug 2018, Recurring
        //public int iBDirectRefundNotify;                // Added by LeeLin, 30 July 2018, B-Direct Refund Notification
        //public int iAllowMPI;                           // Added by Jawad, 6 Sep 2018, MPI
        //public bool bMPIPaymentProcess;                 // Added by Jawad, MPI, 6 Sep 2018
        //public string szAcqBIN;                         // Added by Jawad, MPI, 6 Sep 2018
        //public string szAcqBINType;                     // Added by Jawad, MPI, 6 Sep 2018
        //public string szMPIId;                          // Added by Christian C., MPI, 3 Jan 2019
        //public string szMPIMerchPwd;                    // Added by Jawad, MPI, 6 Sep 2018
        //public string szMPITxnId;                       // Added by Jawad, MPI, 6 Sep 2018
        //public string szPaReq;                          // Added by Jawad, MPI (Response), 6 Sep 2018
        //public string szPaRes;                          // Added by Christian C., MPI (Response), 29 Jan 2019
        //public string szMerchantStateData;              // Added by Jawad, MPI (Response), 6 Sep 2018
        //public string szACSURL;                         // Added by Jawad, MPI (Response), 6 Sep 2018
        //public string szEnrollStatus;                   // Added by Jawad, MPI (Response), 6 Sep 2018
        //public string szErrorCode;                      // Added by Jawad, MPI (Response), 6 Sep 2018
        //public string szTxStatus;                       // Added by Jawad, MPI, 6 Sep 2018
        //public string szMPITxnStatus;                   // Added by Jawad, MPI, 6 Sep 2018
        //public string szMPIAuthTxnStatus;               // Added by Jawad, MPI, 6 Sep 2018
        //public string szMPITxnAmount;                   // Added by Jawad, MPI, 12 Sep 2018

        //public string szMPIResTransID;                  // Added by HFM, 11 Jan 2021, 3DSS
        //public string szMPIReqID;                       // Added by HFM, 11 Jan 2021, 3DSS
        //public string szMPIReqName;                     // Added by HFM, 11 Jan 2021, 3DSS
        //public string szMPIReqURL;                      // Added by HFM, 11 Jan 2021, 3DSS
        //public string szMPIMerchantID;                  // Added by XinYi, 11 Jan 2021, 3DSS

        // Added by LeeLin, 13 Aug 2020, MDS Promotion
        //public int iAllowPromo;
        //public int iPromoCodeFormat;

        // Res to client
        //public int iTxnStatus;
        //public int iTxnState;
        //public int iMerchantTxnStatus;
        //public int iQueryStatus;
        //public int iDuration;

        // Res from Host
        //public string szHostTxnID;
        //public string szRespCode;
        //public string szAuthCode;
        //public string szBankRespMsg;
        //public string szHostDate;
        //public string szHostTime;
        //public string szHostMID;
        //public string szHostTID;
        //public string szHostTxnStatus;
        //public string szHostTxnAmount;
        //public string szHostOrderNumber;
        //public string szHostGatewayTxnID;
        //public string szHostCurrencyCode;
        //public string szHostTxnType;      // Added on 2 Oct 2009
        //public string szEncryptKeyPath;   // Added on 4 Nov 2009, Encrypt key file path
        //public string szDecryptKeyPath;   // Added on 4 Nov 2009, Decrypt key file path
        //public string szRedirectURL;      // Added on 21 Mar 2010
        //public string szECI;              // Added on 5 Oct 2011 by OoiMei for CCGW
        //public string szPayerAuth;        // Added on 5 Oct 2011 by OoiMei for CCGW
        //public string szAVS;              // Added on 17 July 2013 by OoiMei for IPG
        //public string szHostTtlRefundAmt; // Added on 15 Sept 2015 by OoiMei. REFUND
        //public string szHostRefundTxnID;  // Added on 26 Feb 2016 by HFM. Store Refund TxnID different every time and from orig TxnID
        //public string szHostTtlCaptureAmt; // Added on 5 Aug 2016 by OoiMei. Auth&Capture
        //public string szReserved;         // Added by Nick, 23 Mar 2018, GCash

        // Res from Host - Action
        //public int iAction;
        //public bool bVerified;

        // Res from OpenSkies
        //public int iOSRet;
        //public int iErrSet;
        //public int iErrNum;

        // Http connection details
        //public int iHttpTimeoutSeconds;

        // Error
        //public string szTxnMsg;     // RespMesg
        //public string szQueryMsg;
        //public string szErrDesc;
        //public string szDate;
        //public string szTime;

        // Set to true to send request to bank in JSON Format
        //public bool bIsJsonRequest;                                          // Added by Arif, 28 Jan 2018
        //public Dictionary<string, object> dctJsonRequest;                    // Added by Arif, 28 Jan 2018
        //public Dictionary<string, object> dctJsonRequestOption;              // Added by Arif, 28 Jan 2018

        // Set to true to response with JSON Format
        // Add Response data into dctJsonResponse
        //public bool bIsJsonResponse;                                         // Added by Arif, 30 May 2018
        //public Dictionary<string, object> dctJsonResponse;                   // Added by Arif, 30 May 2018. Modified by Arif, 28 Jan 2019, changed 2nd constructor param type from String to Object

        // Added on 23 Jul 2013 by Ooi Mei. IPG
        //public string szCustIP;
        //public string szBillAddr;
        //public string szBillCity;
        //public string szBillRegion;
        //public string szBillPostal;
        //public string szBillCountry;        // Added by Jeff, 31 Jul 2013
        //public string szShipAddr;
        //public string szShipCity;
        //public string szShipRegion;
        //public string szShipPostal;
        //public string szShipCountry;        // Added by Jeff, 31 Jul 2013
        //public string szCustName;           // Added by Jeff, 23 Aug 2013
        //public string szCustEmail;
        //public string szCustPhone;
        //public string szCustMAC;            // Added by Jeff, 23 Aug 2013
        //public string szBINCountry;         // Added by Jeff, 3 Oct 2013
        //public string szBINName;
        //public string szBINPhone;

        // Added by OoiMei, 19 May 2014, Firefly FF
        //public string szCAVV;                // 40 character. eg: AAABCJFQEQAAAAABkFARAAAAAAA=
        //public string sz3dsXID;              // 40 character. eg: NHRkRExIcmhUSHJ3WHFoOU9BMjA=
        //public string sz3DFlag;              // 5 character. eg: 01VYY
        //public string sz3dsEnrolled;         // 1 character which is from sz3DFlag.Substring(3, 1) = Y
        //public string sz3dsStatus;           // 1 character which is from sz3DFlag.Substring(4, 1) = Y
        //public string szMPICode;             // 1 character which is from sz3DFlag.Substring(0,1) = 0 (Success). Added by OoiMei, 13 Jun 2014, Firefly FFCIMB

        // Added by OoiMei 4 July 2014. GlobalPay Cybersource
        //public string szUUID;
        //public string szUTCDateTime;
        //public string szAirlineCode;        // Added by OoiMei, 3 March 2015. Reuse AirlineCode as Trxn Security Code for GPay Reversal.

        // Added by Vicky, 27 Jan 2015, OTC
        //public string szOTCSecureCode;
        //public string szReqTime;
        //public string szDueTime;
        //public string szHostCountryName;    // Added by HFM, display in OTC receipt

        // Added by OoiMei, 21 Apr 2015. Auth&Capture
        //public string szCTxnAmount;
        //public string szCCurrencyCode;
        //public bool bRespCodeCS;             // Added by OoiMei, 25 Aug 2016.
        //public string szTotCaptureAmt;       // Added by OoiMei, 30 Aug 2016.
        //public string szGatewayCaptureTxnID; // Added by HFM, 4 Nov 2019, 10 Apr 2020, AliPayAuth

        // Added by OoiMei, 10 Jul 2015. REFUND
        //public string szTxnAmountOri;
        //public string szTotRefundAmt;
        // Added by HFM, 20 Nov 2015. Promotion
        //public int iPromoExist;
        //public List<string> lPromoList;
        //public int iPromoID;
        //public string szPromoCode;
        //public string szPromoOriAmt;
        //public string szPromotion;
        //public int iPromoActionID;
        //public int iPromoConfirmID;
        // Added by Alex, 11 Oct 2018. Promotion
        //public DataTable dtPromoBinRange;

        // Added by LeeLin, 13 Aug 2020, MDS Promotion
        //public int iValidPromoCode;
        //public string szEntitleOtherPromo;
        //public int iPromoType;
        //public string szPromoListV2;
        ////public string szNewPromoCodes;
        //public int iPromoIsApply;

        // Added by OoiMei, 25 Nov 2015. Installment
        //public int iInstallment;
        //public string szInstallPlan;
        //public string szInstallMthTerm;
        //public int iAllowInstallment;
        //public int iEntitleInstallment;

        // Added by Vicky-711, 25 May 2016
        //public string szDetailID;

        // Added by OoiMei, 2 Aug 2016. HostGroup for FPX2D
        //public string szHGBankID;
        // Added by OoiMei, 10 Oct 2016. MasterPass
        //public string szWalletID;
        //public string szCheckoutStatus;
        //public string szLongAccessToken;
        //public string szPreCheckoutTxnID;
        //public string szPreCheckoutCardLast4;
        //public string szPreCheckoutCardId;
        //public string szPreCheckoutAddrId;
        //public string szReqToken;            // Added 9 Jan 2017
        //public string szPairingReqToken;     // Added 9 Jan 2017
        //public string szReqVerifier;         // Added 10 Jan 2017
        //public string szPairingVerifier;     // Added 10 Jan 2017
        //public string szCheckoutResourceURL; // Added 10 Jan 2017
        //public string szCardList;            // Added 25 Feb 2017 - Masterpass-2
        //public string szHostTxnState;        // Added by Vicky-BTP, 26 Dec 2017
        //public int iGMTDiffMins;             // Added by Vicky-OTC, 21 Feb 2017, to get host country local time
        //public STQrAndBarCodeInfo stQrAndBarcodeInfo; // Added by Alex Ng Nkh, 15 Jan 2019, Barcode and Qrcode.
        //public uint iCustIPNumeric;          // Added by LeeLin, 28 Feb 2019, Malindo
        //public string szMerchantRiskEmail;   // Added by LeeLin, 28 Feb 2019, Malindo
        //public string szIPCountry;           // Added by LeeLin, 28 Feb 2019, Malindo
        //public string szIATACountry;         // Added by LeeLin, 28 Feb 2019, Malindo
        //public string szCardBINCountry;      // Added by LeeLin, 28 Feb 2019, Malindo
        //public int iFraudRet;                // Added by LeeLin, 28 Feb 2019, Malindo
        //public string szPostMethodOri;       // Added by HFM+Jeff, 19 Aug 2019, Boost
        //public bool bMobileBrowser;          // Added by XinYi, 25 Oct 2019, TNG
        //public bool bGetHashValueOnly;       // Added by XinYi, 25 Oct 2019, TNG
        //public int iTokenMethod;             // Added by XinYi, 9 Feb 2020, M4M, Merchant Token Method
        //public int iMerchantRefundNotify;    // Added by XinYi, 31 Mar 2020, Atomy refund notification to merchant
        //public string szCustID;              // Added by HFM, 21 Apr 2020, FPX Payer Identity

        //public int iVIS;                     // Added by Chewwai, 25 August 2020, 31 Oct 2020, VISA installment API - based on merchant settings
        //public string szInstPlanID;          // Added by ChewWai, VISA installment, confirmPlan parameter
        //public string szInstTncUrl;          // Added by ChewWai, VISA installment, confirmPlan parameter
        //public string szInstTncVer;          // Added by ChewWai, VISA installment, confirmPlan parameter
        //public int iInstNum;                 // Added by ChewWai, VISA installment, confirmPlan parameter Number of installment payments required
        //public string szInstFreq;            // Added by ChewWai, VISA installment, confirmPlan parameter Installment frequency, e.g.: "WEEKLY","MONTHLY","BIWEEKLY"
        //public int iInstStatus;              // Added by ChewWai, VISA Installment, installment status
        //public int iMyDebit;                 // Added by XinYi, 11 Jan 2021, 3DSS, MyDebit
        //public string szCaptureHostTxnID;    // Added by LL, 29 Nov 2020, PBB CYBS
        //public string szPaymentNotificationTemplate; // Added by Kelen, 2 Nov 2020, 6 Nov 2020, Payment Notification Template
        //public string szCardBINCountryCode;  // Added by Christian C, 27 Jan 2021, 11 Mar 2021, CIMB Niaga ID, get card issuer bank country code
        //public int iIsFromSDK;               // Added by XinYi, 1 Sept 2021, Atome, indicator to check if the request is from SDK
        //public string szBrowserData;         // Added by XinYi, 1 Sept 2021, Cherri browserColorDepth enhancement
        //public string szMerchantCountry3;    // Added by LWC, 12 Sept 2021, ALB2

        //public int i3DS2AuthStatus;          // Added by LWC, 21 Dec 2021, RHBMPGS
        //public string sz3DSAuthTxnID;        // Added by LWC, 21 Dec 2021, RHBMPGS
        //public string szHostName;            // Added by LWC, 21 Dec 2021, RHBMPGS
        //public bool bBrowserJavaEnabled;     // Added by LWC, 21 Dec 2021, RHBMPGS
        //public string szBrowserLanguage;     // Added by LWC, 21 Dec 2021, RHBMPGS
        //public string szBrowserColorDepth;   // Added by LWC, 21 Dec 2021, RHBMPGS
        //public string szBrowserScreenHeight; // Added by LWC, 21 Dec 2021, RHBMPGS
        //public string szBrowserScreenWidth;  // Added by LWC, 21 Dec 2021, RHBMPGS
        //public string szBrowserTZ;           // Added by LWC, 21 Dec 2021, RHBMPGS
        //public string szAcceptHeader;        // Added by LWC, 21 Dec 2021, RHBMPGS
        //public string szIssuerFIID;          // Added by Alex Ng Nkh, 24 Sep 2021, 21 Dec 2021, for MyDebit CNP (NKH001CNP). the variable holds the value of the credit card's FIID.
        //public string szAuthOriTxnAmount;    // Added by LWC, CIMB3DS2.0, 20 Apr 2022, 25 Apr 2022
        //public string szReqBody;             // Added by LWC, MBBMGATE, 20 Jun 2022
        //public string szMerchantHostParam1;  // Added by XinYi, MBBMGATE, 20 Jun 2022
        //public string szMerchantHostParam2;  // Added by XinYi, MBBMGATE, 20 Jun 2022

        //public bool bIs3DS2ThruPP;           // Added by LL, 3DS2 flow enhancement, 20 Jun 2022

        //public string iCheckTtlRefundAmt;    // Added by LWC, CIMB3DS2.0, 1 Jun 2022, 20 Jun 2022
        //public string szHttpContent;         // Added by Liwen, TMB 2022-12-05 7 Feb 2023
        //public bool bBNBTxn;                // Added by Jeff, 22 May 2023, MyDebitCNP BNB
        //public int iCustomErrHandling;

        // Added by Kelvin for Network tokenization
        //public string szHostToken;           // Added by Kelvin, MBBMGate Tokenization , 31 Mar 2023
        //public string szTokenUniqueReference;
        //public string szTokenExpiry;
        //public string szTokenStatus;
        //public string szTokenProvider;

        public STPayInfo()
        {
            //szTxnType = "";
            //szServiceID = "";
            //szMerchantName = "";
            //szGatewayID = "";
            //szMerchantTxnID = "";
            //szOrderNumber = "";
            //szOrderDesc = "";
            //szTxnAmount = "";
            //szB4TaxAmt = "";
            //szTaxAmt = "";
            //szBaseTxnAmount = "";
            //szToTxnAmount = "";
            //szRTxnAmount = "";
            //szCurrencyCode = "";
            //szBaseCurrencyCode = "";
            //szFXCurrencyCode = "";
            //szFXTxnAmount = "";
            //szFXCurrencyRate = "";
            //szFXCurrencyMarkUp = "";
            //szFXCurrencyOriRate = "";
            //szRCurrencyCode = "";
            //szIssuingBank = "";
            //szLanguageCode = "";
            //szCardPAN = "";
            //szClearCardPAN = "";
            //szCardExp = "";
            //szCardHolder = "";
            //szCVV2 = "";
            //szCardType = "";
            //szCardTypeDesc = "";
            //szSessionID = "";
            //szMerchantSessionID = "";
            //szMerchantReturnURL = "";
            //szMerchantCallbackURL = "";
            //szMerchantApprovalURL = "";
            //szMerchantUnApprovalURL = "";
            //szMerchantCancelURL = "";
            //szMerchantSupportURL = "";
            //szRMerchantReturnURL = "";
            //szMerchantTermsURL = "";
            //szParam1 = "";
            //szParam2 = "";
            //szMaskedParam2 = "";
            //szParam3 = "";
            //szMaskedParam3 = "";
            //szParam4 = "";
            //szParam5 = "";
            //szParam6 = "";
            //szParam7 = "";
            //szParam8 = "";
            //szParam9 = "";
            //szParam10 = "";
            //szParam11 = "";
            //szParam12 = "";
            //szParam13 = "";
            //szParam14 = "";
            //szParam15 = "";
            //szParam16 = "";
            //szParam17 = "";   // Added By Jon, 28 July 2023
            //szPanBin = "";   // Added By Jon, 28 July 2023
            //szBinLastFour = "";   // Added By Jon, 28 July 2023
            //szCorrelationId = "";   // Added By Jon, 28 July 2023
            //szHashMethod = "";
            //szHashValue = "";
            //szHashValue2 = "";
            //szHashKey = "";
            //szHashKeyLog = "";
            //szPostMethod = "";
            //szTxnDateTime = "";
            //szMerchantStreetAddress = "";
            //szMerchantCity = "";
            //szMerchantState = "";
            //szMerchantCountry = "";
            //szMerchantAddress = "";
            //szMerchantContactNo = "";
            //szMerchantEmailAddr = "";
            //szMerchantNotifyEmailAddr = "";
            //szMerchantWebSiteURL = "";
            //szMerchantValidDomain = "";
            //szMerchantIP = "";
            //szPymtMethod = "";
            //szPMEntry = "0";
            //szFromRetrySvc = "0";
            //bMultiEntries = false;
            //szTokenType = "";
            //szToken = "";
            //szToken2 = "";
            //szCustOCP = "";
            //szDDCountryCode = "";
            //szProtocol = "";
            //szAcqCountryCode = "";
            //iReqRes = 1;
            //iTxnIDMaxLen = 0;
            //szMaskedCardPAN = "";
            //szTxnID = "";
            //szMachineID = "";
            //szRecv2ndEntry = "";
            //szHTML = "";
            //szRespContent = "";
            //iTxnStatus = -1;
            //iTxnState = -1;
            //iMerchantTxnStatus = -1;
            //iPKID = -1;
            //szHostTxnID = "";
            //szRespCode = "";
            //szAuthCode = "";
            //szBankRespMsg = "";
            //szHostDate = "";
            //szHostTime = "";
            //szHostMID = "";
            //szHostTID = "";
            //szHostTxnStatus = "";
            //szHostTxnAmount = "";
            //szHostOrderNumber = "";
            //szHostGatewayTxnID = "";
            //szHostCurrencyCode = "";
            //szHostTxnType = "";
            //szEncryptKeyPath = "";
            //szDecryptKeyPath = "";
            //szRedirectURL = "";
            //szECI = "";
            //szPayerAuth = "";
            //szAVS = "";
            //szHostTtlRefundAmt = "0";
            //szHostRefundTxnID = "";
            //szHostTtlCaptureAmt = "0";
            //szReserved = "";
            //iAction = 0;
            //bVerified = true;
            //iOSRet = 99;
            //iErrSet = -1;
            //iErrNum = -1;
            //iHttpTimeoutSeconds = 0;
            //iQueryStatus = 2;
            //iDuration = -1;
            //szTxnMsg = "";
            //szQueryMsg = "";
            //szErrDesc = "";
            //szMerchantName2 = "";
            //szMerchantPassword = "";
            //szPaymentTemplate = "";
            //szErrorTemplate = "";
            //szRunningNo = "";
            //iAllowReversal = 0;
            //iAllowFDS = 0;
            //iAllowExtFDS = 0;
            //iCollectShipAddr = 0;
            //iCollectBillAddr = 0;
            //iAllowMaxMind = 0;
            //szFraudByAmt = "";
            //iAllowPayment = 0;
            //iAllowQuery = 0;
            //iAllowDD = 0;
            //iAllowOTC = 0;
            //iAllowWallet = 0;
            //iAllowOCP = 0;
            //iAllowCallBack = 0;
            //iAllowFX = 0;
            //iRouteByParam1 = 0;
            //i3DAccept = 3;
            //iSelfMPI = 0;
            //iVISA = 0;
            //iMasterCard = 0;
            //iAMEX = 0;
            //iJCB = 0;
            //iDiners = 0;
            //iCUP = 0;
            //iMyDebitCNP = 0;
            //iMasterPass = 0;
            //iVisaCheckout = 0;
            //iSamsungPay = 0;
            //iGooglePay = 0;
            //iMyDebitSrc = 0;
            //iMastercardC2P = 0;
            //iPageTimeout = 0;
            //iSvcType = 0;
            //iNeedAddOSPymt = 0;
            //iTxnExpired_S = 0;
            //iReceipt = 0;
            //iPymtNotificationEmail = 0;
            //iPymtNotificationSMS = 0;
            //iAutoReversal = 0;
            //iRespMethod = 1;
            //dPerTxnAmtLimit = 0;
            //iHCProfileID = 0;
            //dMerchFXRate = 0;
            //iShowMerchantAddr = 1;
            //iShowMerchantLogo = 1;
            //szExtraCSS = "";
            //iOTCExpiryHour = 0;
            //iReturnCardData = 0;
            //szSettleTAID = "";
            //szSettleAmount = "";
            //szSettleCount = "";
            //iMCCCode = 0;
            //iFDSActionID = 0;
            //iFDSRespCode = 0;
            //szFDSCustomerID = "";
            //szFDSAuthCode = "";
            //szFDSRespMsg = "";
            //szFDSError = "";
            //szFDSDeclineRule = "";
            //szFDSScoreReason = "";
            //szFDSEmailTemplate = "";
            //szPostCode = "";
            //iCVVRequire = 1;
            //szDate = "";
            //szTime = "";
            //bIsJsonResponse = false;
            //bIsJsonRequest = false;
            //szCustIP = "";
            //szCustName = "";
            //szCustEmail = "";
            //szCustPhone = "";
            //szCustMAC = "";
            //szBillAddr = "";
            //szBillCity = "";
            //szBillRegion = "";
            //szBillPostal = "";
            //szBillCountry = "";
            //szShipAddr = "";
            //szShipCity = "";
            //szShipRegion = "";
            //szShipPostal = "";
            //szShipCountry = "";
            //szBINCountry = "";
            //szBINName = "";
            //szBINPhone = "";
            //szCAVV = "";
            //sz3dsXID = "";
            //sz3DFlag = "";
            //sz3dsEnrolled = "";
            //sz3dsStatus = "";
            //szMPICode = "";
            //szUUID = "";
            //szUTCDateTime = "";
            //szAirlineCode = "";
            //szOTCSecureCode = "";
            //szReqTime = "";
            //szDueTime = "";
            //szHostCountryName = "";
            //szTxnAmountOri = "0";
            //szTotRefundAmt = "0";
            //iPromoExist = -1;
            //iPromoID = -1;
            //lPromoList = null;
            //szPromoCode = "";
            //szPromoOriAmt = "";
            //szPromotion = "";
            //iPromoActionID = 0;
            //iPromoConfirmID = 0;
            //iInstallment = 0;
            //szInstallPlan = "";
            //szInstallMthTerm = "";
            //iAllowInstallment = 0;
            //iEntitleInstallment = 0;
            //szHGBankID = "";
            //szCTxnAmount = "";
            //szCCurrencyCode = "";
            //bRespCodeCS = false;
            //szTotCaptureAmt = "0";
            //szGatewayCaptureTxnID = "";
            //szWalletID = "";
            //szCheckoutStatus = "";
            //szLongAccessToken = "";
            //szPreCheckoutTxnID = "";
            //szPreCheckoutCardLast4 = "";
            //szPreCheckoutCardId = "";
            //szPreCheckoutAddrId = "";
            //szReqToken = "";
            //szPairingReqToken = "";
            //szReqVerifier = "";
            //szPairingVerifier = "";
            //szCheckoutResourceURL = "";
            //szCardList = "";
            //szDetailID = "";
            //szHostTxnState = "";
            //iGMTDiffMins = 0;
            //iAllowRefund = 0;
            //iQuantity = 1;
            //szFailureCallBackNotifyEmailAddr = "";
            //szChargeBackEmailAddr = "";
            //szMerchantMainContactEmail = "";
            //szMerchantMainContactNo = "";
            //szMerchantMainContactName = "";
            //szRecurrDuration = "";
            //szRecurrStartDate = "";
            //szRecurrEndDate = "";
            //iRecurrFreqNum = 0;
            //szRecurrFreqUnit = "";
            //szRecurrCriteria = "";
            //iAllowRecurring = 0;
            //szCustRecurr = "";
            //szRecurrAmount = "";
            //iBDirectRefundNotify = 0;
            //iAllowQuantityDisplay = 0;
            //szTxnTypeX = "";
            //iAllowMPI = 0;
            //bMPIPaymentProcess = false;
            //szAcqBIN = "";
            //szAcqBINType = "";
            //szMPIId = "";
            //szMPIMerchPwd = "";
            //szMPITxnId = "";
            //szPaReq = "";
            //szPaRes = "";
            //szMerchantStateData = "";
            //szACSURL = "";
            //szEnrollStatus = "";
            //szErrorCode = "";
            //szTxStatus = "";
            //szMPITxnStatus = "";
            //szMPIAuthTxnStatus = "";
            //szMPITxnAmount = "";
            //szMPIResTransID = "";
            //szMPIReqID = "";
            //szMPIReqName = "";
            //szMPIReqURL = "";
            //szMPIMerchantID = "";
            //iCustIPNumeric = 0;
            //szMerchantRiskEmail = "";
            //szIPCountry = "";
            //szIATACountry = "";
            //szCardBINCountry = "";
            //iFraudRet = 0;
            //szPostMethodOri = "";
            //bMobileBrowser = false;
            //bGetHashValueOnly = false;
            //iTokenMethod = 0;
            //iMerchantRefundNotify = 0;
            //szCustID = "";
            //iAllowPromo = 0;
            //iValidPromoCode = 0;
            //szEntitleOtherPromo = "";
            //iPromoType = 0;
            //szPromoListV2 = "";
            //iPromoIsApply = 0;
            //iPromoCodeFormat = 0;
            //iVIS = 0;
            //szInstPlanID = "";
            //szInstTncUrl = "";
            //szInstTncVer = "";
            //iInstNum = 0;
            //szInstFreq = "";
            //iInstStatus = 0;
            //iMyDebit = 0;
            //szTxnTypeQ = "";
            //szCaptureHostTxnID = "";
            //szPaymentNotificationTemplate = "";
            //bUpdateParam = false;
            //InitQrAndBarCodeInfo(ref stQrAndBarcodeInfo);
            //szCardBINCountryCode = "";
            //iIsFromSDK = 0;
            //szBrowserData = "";
            //szMerchantCountry3 = "";
            //i3DS2AuthStatus = -3;
            //sz3DSAuthTxnID = "";
            //szHostName = "";
            //bBrowserJavaEnabled = false;
            //szBrowserLanguage = "";
            //szBrowserColorDepth = "";
            //szBrowserScreenHeight = "";
            //szBrowserScreenWidth = "";
            //szBrowserTZ = "";
            //szAcceptHeader = "";
            //szIssuerFIID = "";
            //szAuthOriTxnAmount = "";
            //szReqBody = "";
            //szMerchantHostParam1 = "";
            //szMerchantHostParam2 = "";
            //szHostToken = "";
            //bIs3DS2ThruPP = false;
            //iCheckTtlRefundAmt = "1";
            //szHttpContent = "";
            //bBNBTxn = false;
            //iCustomErrHandling = 0;
            // might need another database storing the KEK, because this part need to get the info of it
        }

        public void InitQrAndBarCodeInfo(ref STQrAndBarCodeInfo st_QrNadBarcodeInfo)
        {
            st_QrNadBarcodeInfo.szRawStrFormat = "";
            st_QrNadBarcodeInfo.szRawStrParam = "";
            st_QrNadBarcodeInfo.szRawStrBcDisp = "";
            st_QrNadBarcodeInfo.iBarOrQrOption = -1;
            st_QrNadBarcodeInfo.szBarcodeSymbology = "";
            st_QrNadBarcodeInfo.szBarcodeDispWidth = "";
            st_QrNadBarcodeInfo.szBarcodeDispHeight = "";
            st_QrNadBarcodeInfo.szQrcodeDispWidth = "";
            st_QrNadBarcodeInfo.szQrcodeDispHeight = "";
            st_QrNadBarcodeInfo.szBarcodeScl = "";
            st_QrNadBarcodeInfo.szQrcodeScl = "";
            st_QrNadBarcodeInfo.szQrCodeLogo = "";
            st_QrNadBarcodeInfo.szBarcodeImgLocation = "";
            st_QrNadBarcodeInfo.szQrcodeImgLocation = "";
            st_QrNadBarcodeInfo.szImageType = "";
            st_QrNadBarcodeInfo.iNewLineType = 1;
            st_QrNadBarcodeInfo.szReceiptTemplate = "";  // Added by Phop, 23 Apr 2019, TBank OTC, for special template
            st_QrNadBarcodeInfo.szEmailTemplate = "";    // Added by Phop, 23 Apr 2019, TBank OTC, for special template
            st_QrNadBarcodeInfo.szQrErrorCorrection = "";    // Added by Alex Ng, 25 Oct 2019, QRPAY, generate QR with error correction (matrix)
        }

    }

}
