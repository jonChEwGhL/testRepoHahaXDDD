namespace Domain.Models.Structure
{
    public struct STQrAndBarCodeInfo
    {
        public string szRawStrFormat;
        public string szRawStrParam;
        public string szRawStrBcDisp;
        public int iBarOrQrOption;
        public string szBarcodeSymbology;
        public string szBarcodeDispWidth;
        public string szBarcodeDispHeight;
        public string szQrcodeDispWidth;
        public string szQrcodeDispHeight;
        public string szBarcodeScl;
        public string szQrcodeScl;
        public string szQrCodeLogo;
        public string szBarcodeImgLocation;
        public string szQrcodeImgLocation;
        public string szImageType;
        public int iNewLineType;
        public string szReceiptTemplate;   // Added by Phop, 23 Apr 2019, for special needed template.
        public string szEmailTemplate;     // Added by Phop, 23 Apr 2019, for special needed template.
        public string szQrErrorCorrection; // Added by Alex Ng, 25 Oct 2019, QRPAY, generate QR with error correction (matrix)
    }
}
