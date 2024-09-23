########## ##########
cmake_minimum_required(VERSION 3.9.1)

########## PROJECT NAME ##########
set(PROJECT_NAME Bitmeter)
project(${PROJECT_NAME})

########## FIND wxWidgets PACKAGES ##########
find_package(wxWidgets REQUIRED COMPONENTS net core base)

########## ##########
if(wxWidgets_USE_FILE) # not defined in CONFIG mode
    include(${wxWidgets_USE_FILE})
endif()

########## EXECUTABLES ##########
add_executable(${PROJECT_NAME}
                "src/main.cpp"
                "src/frame.cpp")

########## ##########
target_link_libraries(${PROJECT_NAME} ${wxWidgets_LIBRARIES})

########## ##########
include_directories("img")

########## OUTPUT PATH ##########
set(EXECUTABLE_OUTPUT_PATH "bin")
