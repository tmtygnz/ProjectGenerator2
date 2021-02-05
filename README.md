# Project Generator 2
This is a customizable project generator created using C#

## Installation
Go to the releases page of this repository to download the latest build or click [here](https://github.com/jostimian/ProjectGenerator2/releases)

## Usage
Extract the compressed file and run the executable
### Generating a new project
- Choose a programming language
- Choose the file path where you want to generate the project
- Click generate and start coding
![Demo](./img/GenerateNewProjectDemo.gif)

### Adding and Editing Templates
- Open the config.yml in `file` -> `Edit Generator Preferences`
 
| Key          	| Value Type 	| What for                                                                                                             	|
|--------------	|------------	|----------------------------------------------------------------------------------------------------------------------	|
| languages    	| Array      	| Array of project templates                                                                                           	|
| langName     	| String     	| Name of the template or programming language 
| pushToGit     | int			| 1 = push to VSC after the template is generated 0 = do not push to VSC after the template is generate
| OpenTerminal 	| int        	| 1 = open the terminal after the template is generated 0 = do not open the terminal after the template is generated   	|
| OpenExplorer 	| int        	| 1 = open ther exploerer after the template is generated 0 = do not open the terminal after the template is generated 	|
| folders      	| array      	| Arrays of folders to create                                                                                          	|
| folderName   	| String     	| Name of the folder that will be created                                                                              	|
| files        	| arrays     	| Arrays of files to be created                                                                                        	|
| filePath     	| string     	| Path where the file will be created                                                                                  	|
| fileName     	| string     	| Name of the file                                                                                                     	|
| fileContent  	| string     	| Code or content of the file                                                                                   	|
## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.