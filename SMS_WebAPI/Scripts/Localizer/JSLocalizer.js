function localize(key, culture)
{
    var localizedText = "hello from localizer";
    if (culture.toLowerCase() === 'en')
        localizedText = resource_En[key];
    if (culture.toLowerCase() === 'ar')
        localizedText = resource_Ar[key];
    return localizedText;
}