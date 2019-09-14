cmake_minimum_required(VERSION 3.6)
#set_property(GLOBAL PROPERTY USE_FOLDERS ON)
#set_property(GLOBAL PROPERTY PREDEFINED_TARGETS_FOLDER "cmake")

set(Boost_USE_STATIC_LIBS OFF)
set(Boost_USE_MULTITHREADED ON)

project(Archiver LANGUAGES CXX)
	
set(CMAKE_INCLUDE_CURRENT_DIR ON)

find_package(Qt5 REQUIRED COMPONENTS Core Widgets Gui)
find_package(zlib)
find_package(QuaZip5)
include_directories(${QUAZIP_INCLUDE_DIRS})

set(project_ui
    mainwindow.ui)
set(project_headers
    archive.h
    mainwindow.h)
set(project_sources
    main.cpp
    archive.cpp
    mainwindow.cpp)

qt5_wrap_ui(project_headers_wrapped ${project_ui})
qt5_wrap_cpp(project_sources_moc ${project_headers})

add_executable(${PROJECT_NAME} ${project_headers} ${project_sources} 
    ${project_sources_moc} ${project_headers_wrapped})

target_link_libraries(${PROJECT_NAME} 
    PUBLIC 
    Qt5::Core
    Qt5::Gui
    Qt5::Widgets
    ${QUAZIP_LIBRARIES}
)

add_custom_command(TARGET Archiver POST_BUILD    
    COMMAND ${CMAKE_COMMAND} -E copy_if_different  
        "${QUAZIP_LIBRARIES}/quazip5.dll"     
        $<TARGET_FILE_DIR:Archiver>)  