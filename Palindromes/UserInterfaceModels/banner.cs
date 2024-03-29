namespace Palindromes.UserInterfaceModels
{
  class WelcomeBanner
  {
    public static string Welcome { get; } = @"
 ________  ________  ___       ___  ________   ________  ________  ________  _____ ______   _______      
|\   __  \|\   __  \|\  \     |\  \|\   ___  \|\   ___ \|\   __  \|\   __  \|\   _ \  _   \|\  ___ \     
\ \  \|\  \ \  \|\  \ \  \    \ \  \ \  \\ \  \ \  \_|\ \ \  \|\  \ \  \|\  \ \  \\\__\ \  \ \   __/|    
 \ \   ____\ \   __  \ \  \    \ \  \ \  \\ \  \ \  \ \\ \ \   _  _\ \  \\\  \ \  \\|__| \  \ \  \_|/__  
  \ \  \___|\ \  \ \  \ \  \____\ \  \ \  \\ \  \ \  \_\\ \ \  \\  \\ \  \\\  \ \  \    \ \  \ \  \_|\ \ 
   \ \__\    \ \__\ \__\ \_______\ \__\ \__\\ \__\ \_______\ \__\\ _\\ \_______\ \__\    \ \__\ \_______\
    \|__|     \|__|\|__|\|_______|\|__|\|__| \|__|\|_______|\|__|\|__|\|_______|\|__|     \|__|\|_______|";
  }

  class GoodbyeBanner
  {
    public static string Goodbye { get; } = @"
 ________  ________  ________  ________  ________      ___    ___ _______      
|\   ____\|\   __  \|\   __  \|\   ___ \|\   __  \    |\  \  /  /|\  ___ \     
\ \  \___|\ \  \|\  \ \  \|\  \ \  \_|\ \ \  \|\ /_   \ \  \/  / | \   __/|    
 \ \  \  __\ \  \\\  \ \  \\\  \ \  \ \\ \ \   __  \   \ \    / / \ \  \_|/__  
  \ \  \|\  \ \  \\\  \ \  \\\  \ \  \_\\ \ \  \|\  \   \/  /  /   \ \  \_|\ \ 
   \ \_______\ \_______\ \_______\ \_______\ \_______\__/  / /      \ \_______\
    \|_______|\|_______|\|_______|\|_______|\|_______|\___/ /        \|_______|
                                                     \|___|/                   
                                                                               
                                                                               ";
  }

  class SuccessBanner
  {
    public static string Success { get; } = @"
 ________  ___  ___  ________  ________  _______   ________   ________      
|\   ____\|\  \|\  \|\   ____\|\   ____\|\  ___ \ |\   ____\ |\   ____\     
\ \  \___|\ \  \\\  \ \  \___|\ \  \___|\ \   __/|\ \  \___|_\ \  \___|_    
 \ \_____  \ \  \\\  \ \  \    \ \  \    \ \  \_|/_\ \_____  \\ \_____  \   
  \|____|\  \ \  \\\  \ \  \____\ \  \____\ \  \_|\ \|____|\  \\|____|\  \  
    ____\_\  \ \_______\ \_______\ \_______\ \_______\____\_\  \ ____\_\  \ 
   |\_________\|_______|\|_______|\|_______|\|_______|\_________\\_________\
   \|_________|                                      \|_________\|_________|
                                                                            
                                                                            ";
  }

  class FailBanner
  {
    public static string Fail { get; } = @"
 ________ ________  ___  ___          
|\  _____\\   __  \|\  \|\  \         
\ \  \__/\ \  \|\  \ \  \ \  \        
 \ \   __\\ \   __  \ \  \ \  \       
  \ \  \_| \ \  \ \  \ \  \ \  \____  
   \ \__\   \ \__\ \__\ \__\ \_______\
    \|__|    \|__|\|__|\|__|\|_______|
                                      
                                      
                                      ";
  }
}