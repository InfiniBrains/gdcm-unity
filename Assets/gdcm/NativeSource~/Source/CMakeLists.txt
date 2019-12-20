# Find all .c, .cc and .cpp files in the source folder
# Add your glue code etc...
file(GLOB_RECURSE SOURCE_FILES "${SOURCE_FOLDER}/*.hpp" "${SOURCE_FOLDER}/*.h" "${SOURCE_FOLDER}/*.c" "${SOURCE_FOLDER}/*.cc" "${SOURCE_FOLDER}/*.cpp")

add_library(${PLUGIN_NAME} ${SOURCE_FILES})

# add dependencies or link
#add_subdirectory(externallibfolder)
#target_link_libraries (${PLUGIN_NAME} externallibname)