# ![QsoLink-Logbook](https://www.lopastudio.sk/img/QSOLinkLogBook.png)
# QsoLink Logbook
<table>
<tr>
<td>
  A QSOLink Logbook is a simple digital QSO logging software. It is focused on Ease of Use.
</td>
</tr>
</table>


## Demo
When the application is going to be in Alpha 2 version, I am going to publish first official compiled version. For now, you will need to compile your own version.



## Compiling 

1. Download the project files `git clone https://github.com/Lopastudio/QSOLink-Logbook/`
2. Next, you will need to download Visual Studio 2022 and install dotNET Desktop Development package.
3. After you opened up the project in Visual Studio, switch the configuration from Debug to Release. This is a dropdown, located on the top left of your screen.
4. Next, press `CTRL + B` or go to the `Build` tab on the top and click the `Build QSOLink Logbook` button. 
5. And finally, after building the project, Visual Studio should return an path to the compiled build. It should be located in the project folder. In there go to the `Bin` and the into `Release` folders, and there is your application.
6. And thats all.

### Development
Want to contribute? Great!

To fix a bug or enhance an existing module, follow these steps:

- Fork the repo
- Make the appropriate changes in the files
- Add changes to reflect the changes made.
- Commit your changes
- Push to the branch
- Create a Pull Request 

### Bug / Feature Request

If you find a bug, kindly open an issue [here](https://github.com/Lopastudio/QSOLink-Logbook/issues/new) by including your search query and the expected result.

If you'd like to request a new function, feel free to do so by opening an issue [here](https://github.com/Lopastudio/QSOLink-Logbook/issues/new). Please include sample queries and their corresponding results.

## To-do
- Add the REMOVE button.
- Make the interface prettier.

## Currently known bugs (bugs to be fixed)
- To edit, you need to click on a row, you want to edit but you need to click on a text
- If user removes an contact, the application would assign wrong index number. 


## [License](https://github.com/Lopastudio/QSOLink-Logbook/blob/master/LICENSE.txt)
This project is licensed under the `Apache License 2.0`.

