// "Copyright 2018 <Ipatov D.D.>"

  /*!
  \file
  \brief Заголовочный файл с описанием класса Archive

  Данный файл содержит информацию о классе Archive
  */
#ifndef PRJ_COURSEWORK_ARCHIVER_ARCHIVE_H_
#define PRJ_COURSEWORK_ARCHIVER_ARCHIVE_H_

#include <QTableWidget>
#include <JlCompress.h>
#include <QString>

  /*!
   * \brief The Archive class
   *
   * Класс, реализующий работу с архивом
   */

class Archive {
 public:
  Archive() = default;

  ~Archive();

  explicit Archive(const QString& name);

  Archive(const Archive& obj);

  void operator=(const Archive& obj);

  /*!
   * Изменяет текущий открытый zip-файл-current_zip_
   * \param name Путь к архиву
   */
  void change_zip(const QString& name);

  /*!
   * Выводит информацию о текущем ZIP-файле в table
   * \param table-ссылка на QTableWidget, к которую необходимо вывести информацию об архиве
   */
    void table_output(QTableWidget& table);

  /*!
   * Создает новый ZIP-файл по пути path и изменяет current_zip_ и path_
   * \param path путь для создания нового архива
   * \return true,если архив успешно создан, в противном случае false
   */
  bool create_new_zip(const QString& path);

  /*!
   * Добавляет новые файлы в текущий архив
   * \param strings информация о пути к выбранным файлам для добавления в архив
   * \return true,если файлы успешно добавлены, в противном случае false
   */
  bool add_new_files(const QStringList& strings);

  /*!
   * Разархивирует текущий архив в path
   * \param path путь для разархивирования
   * \return true,если ZIP-файл успешно разархивирован, в противном случае false
   */
  bool unzip_to_folder(const QString& path);

  /*!
   * Заархивировать диреккторию по пути path в path_save
   * \param path Путь директории для архивирования
   * \param path_save Путь, куда заархивировать директорию path
   */
  void zip_folder(const QString& path, const QString& path_save);

 private:
  QuaZip* current_zip_{nullptr}; ///< Текущий ZIP-файл
  QString path_{};///< Путь к текущему ZIP-файлу
};

#endif  // PRJ_COURSEWORK_ARCHIVER_ARCHIVE_H_
