// "Copyright 2018 <Ipatov D.D.>"

#ifndef PRJ_COURSEWORK_ARCHIVER_MAINWINDOW_H_
#define PRJ_COURSEWORK_ARCHIVER_MAINWINDOW_H_

#include <QMainWindow>

namespace Ui {
class MainWindow;
}

/*!
 * \brief The MainWindow class
 *
 * Данный класс делает возможным работу с графическими инструментами
 */
class MainWindow : public QMainWindow {
    Q_OBJECT

 public:
    explicit MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

 private slots:

    /*!
     * \brief Срабатывает при выборе пункта меню "Открыть архив"
     *
     * Открывает архив по выбранному пути и выводит информацию о нем в таблицу
     */
    void on_open_archive_triggered();

    /*!
     * \brief Срабатывает при выборе пункта меню "Выход"
     *
     * Выводит диалоговое меню, в случае выбора "Yes"- закрывает программу
     */
    void on_exit_triggered();

    /*!
     * \brief Срабатывает при выборе пункта меню "Создать архив"
     *
     * Выводит окно с выбором пути создания нового архива и создает архив
     */
    void on_create_archive_triggered();

    /*!
     * \brief Изменяет текст в окне с путем к архиву на path
     * \param path - Путь к архиву
     */
    void change_path(const QString& path);

    /*!
     * \brief Срабатывает при выборе пункта меню "Добавить файлы в архив"
     *
     * Выводит окно с выбором файлов, которые будут добавлены в текущий архив
     */
    void on_add_files_to_archive_triggered();

    /*!
     * \brief Выводит информацию о текущем архиве в таблицу
     */
    void output_table();

    /*!
     * \brief Срабатывает при выборе пункта меню "Разархивировать в папку"
     *
     * Выводит окно с выбором пути для сохранения текущего архива
     * и разахивирует по данному пути архив
     */
    void on_unzip_to_folder_triggered();

    /*!
     * \brief Срабатывает при выборе пункта меню "Заархивирование папки"
     *
     * Выводит сначала окно с выбором папки, а затем окно
     * с выбором пути создания нового архива и сохранения в него выбранной папки
     */
    void on_zipping_folder_triggered();

    /*!
     * \brief Срабатывает при выборе пункта меню "Помощь"
     *
     * Выводит окно с описанием программы
     */
    void on_help_triggered();

 private:
    Ui::MainWindow *ui;///<Хранит ссылку на текущий MainWindow
};

#endif  // PRJ_COURSEWORK_ARCHIVER_MAINWINDOW_H_
