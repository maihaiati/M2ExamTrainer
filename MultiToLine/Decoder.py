################################################
#        One line to multiline converter       #
#                                              # 
#   USAGE: Run this tool and input one line    #
#   data. This tool will be convert to         #
#   multiline data.                            #
#                                              # 
#        Created by M2Tech - Mai Hai           #
################################################

data = input("Input data: ")
decoded = data.replace('<br>', '\n').replace('&nbsp;', ' ').replace("&lt;", "<").replace("&gt;", ">")
print(decoded)