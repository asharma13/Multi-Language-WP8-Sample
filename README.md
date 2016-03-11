## Multi-Language WP8 Sample
*Long story short...*
I was working with a multi language windows phoen app. I found [Multilingual app toolkit](https://dev.windows.com/en-us/develop/multilingual-app-toolkit "Multilingual app toolkit"). It was able to use translator & make your app multilingual in minutes. 

_**But I found a problem.**_ App language was automatically selected based on Region in WP settings. Now what if a person need different language then his region setting. _For eg. here in India, many people use English in phone, but how they can tell that this particular app they want to access in Hindi._

To overcome this problem we edited **App.xaml.cs** InitializePhoneApplication() function. Whenever initialized, the language will be hindi. User can change this from Application bar.

So enjoy this simple, yet useful sample file & create some great apps. :)