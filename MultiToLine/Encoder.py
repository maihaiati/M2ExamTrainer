################################################
#        Multiline to one line converter       #
#                                              # 
#   USAGE: Put the multiline data need to      #
#   be convert to one line data in file        # 
#   Data.txt and run this tool                 #
#                                              #
#        Created by M2Tech - Mai Hai           #
################################################ 

output = ""
with open('.\Data.txt', 'r', encoding='utf-8') as file:
    lines = file.readlines()
    for line in lines:
        output = output + line.replace("<", "&lt;").replace(">", "&gt;").replace('\n', '<br>').replace(' ', '&nbsp;').replace('\t', '&nbsp;&nbsp;&nbsp;&nbsp;')
        
print(output)