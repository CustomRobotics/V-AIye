# 
# Usage: To re-create this platform project launch xsct with below options.
# xsct C:\Users\softw\source\repos\CustomRobotics\V-AIye\KV260\CR_KV260\cr_kv260\platform.tcl
# 
# OR launch xsct and run below command.
# source C:\Users\softw\source\repos\CustomRobotics\V-AIye\KV260\CR_KV260\cr_kv260\platform.tcl
# 
# To create the platform in a different location, modify the -out option of "platform create" command.
# -out option specifies the output directory of the platform project.

platform create -name {cr_kv260}\
-hw {C:\Users\softw\source\repos\CustomRobotics\V-AIye\KV260\CR_KV260\cr_kv260_bd_wrapper.xsa}\
-proc {psu_cortexa53} -os {linux} -arch {64-bit} -fsbl-target {psu_cortexa53_0} -out {C:/Users/softw/source/repos/CustomRobotics/V-AIye/KV260/CR_KV260}

platform write
platform active {cr_kv260}
platform generate
