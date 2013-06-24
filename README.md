SeleniumFrameworkSample
=======================

Sample project using the automation framework
___________________________________________________________
ABOUT THE FRAMEWORK AND HOW IT WILL BE USED IN THIS SAMPLE
___________________________________________________________

This is a wrapper created over Selenium. I have tried to expose all possible functionalities/methods that Selenium provides. This framework will help provide you test project some structure. You will be able to create an instance of an application and group your methods into logical pages. The actual tests will then just refer to these methods that are in a page. I have provided a way in which you can use control files and not use page controls directly in your methods. The CSVReader file helps to read and csv file which will have key value pairs as in the control selector and its name. This will prove to be helpful when you want to change the selector of a control, you would only have to change it once in the control csv file. You will also have to create an app class in your project which will inherit from UIApplication, wherein you will be able to map your logical pages to one or more control files (.csv files). So if you open this sample project which uses the automation framework there are a couple of things you will notice such as the reference of the automation dll, the different folders for Controls and Pages.
