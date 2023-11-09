namespace Domain.Models.Global
{
    public class STQrAndBarCodeInfo
    {
        public string szRawStrFormat { get; set; } = "";
        public string szRawStrParam { get; set; } = "";
        public string szRawStrBcDisp { get; set; } = "";
        public int iBarOrQrOption { get; set; } = -1;
        public string szBarcodeSymbology { get; set; } = "";
        public string szBarcodeDispWidth { get; set; } = "";
        public string szBarcodeDispHeight { get; set; } = "";
        public string szQrcodeDispWidth { get; set; } = "";
        public string szQrcodeDispHeight { get; set; } = "";
        public string szBarcodeScl { get; set; } = "";
        public string szQrcodeScl { get; set; } = "";
        public string szQrCodeLogo { get; set; } = "";
        public string szBarcodeImgLocation { get; set; } = "";
        public string szQrcodeImgLocation { get; set; } = "";
        public string szImageType { get; set; } = "";
        public int iNewLineType { get; set; } = 1;
        public string szReceiptTemplate { get; set; } = "";    // Added by Phop, 23 Apr 2019, for special needed template.
        public string szEmailTemplate { get; set; } = "";      // Added by Phop, 23 Apr 2019, for special needed template.
        public string szQrErrorCorrection { get; set; } = "";  // Added by Alex Ng, 25 Oct 2019, QRPAY, generate QR with error correction (matrix)
    }
}
