function convertToShortDate(dateString) {
    const shortDate = new Date(dateString).toLocaleDateString('tr-TR');
    return shortDate;
}

function convertFirstLetterToUpperCase(text) {
    text = text.toString();
    const convertedText = text.charAt(0).toUpperCase() + text.slice(1).toLowerCase();//ilk harfini al büyük harfe çevir ve birinci harfden sonrasının devamını al diyoruz ve en son kalanları küçüğe çevir
    return convertedText;
}