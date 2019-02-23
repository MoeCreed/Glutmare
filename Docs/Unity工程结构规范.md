# Unity工程结构规范



| 目录                | 含义                                                         |
| -------------------------- | ------------------------------------------------------------ |
| Assets              | Unity3d 默认主目录                                           |
| ┣ Editor     | 编辑器类存放文件夹①                                          |
| ┣ ExternalLibraries | 大型完善的外部库文件存放目录② |
| ┣ GameAssets | 游戏美术资源存放地 |
| ┃ ┣ Materials | 材质球 |
| ┃ ┣ Models | 模型③ |
| ┃ ┣ Animations | 用新的Mecanim时，存放动画文件 |
| ┃ ┣ Prefabs | 不需要Resource.Load加载的预制体 |
| ┃ ┣ Sounds | 声音文件 |
| ┃ ┣ Textures | 贴图文件 |
| ┃ ┗ UI | 一些UI文件，如Atlas等 |
| ┣ Plugins | dll和一些纯代码插件 |
| ┣ Resources | 所有需要通过Resource.Load加载的资源 |
| ┣ Scenes | Scenes文件存放目录 |
| ┣ Scripts | 代码目录 |
| ┗ StreamingAssets | 将原样复制到目标设备上的文件 |

注：

①：如NGUI等拥有完善的目录结构和大量代码的插件，就存放在此目录。有些人喜欢把NGUI目录直接存放在plugins目录下其实是不太好的，因为plugins文件夹也是要参与编译的。

②：因为美术童鞋都是单独工程进行编辑，然后导出unitypackage文件，这个文件最大的坏处就是在导入时可能会污染目录结构，导致每次导入文件，均要手动调整目录，而单独命名一个GameAssets目录，再把这个目录复制到美术童鞋的工程里面，让美术童鞋编辑玩资源后，只把需要导出的资源放入这个目录存放妥当，再导出unitypackage文件。

③：如果动画系统采用animation，把动画文件和原始模型存放在同一目录下，如果采用animtor，因为动画重用的关系，动画文件需单独存放。